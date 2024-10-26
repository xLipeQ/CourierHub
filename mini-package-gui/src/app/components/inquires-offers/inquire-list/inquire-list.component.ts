import { ChangeDetectorRef, Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Address } from '../../../models/address';
import { InquireWithOffer } from '../../../models/inquire.with.offer';
import { PagingRequest } from '../../../models/paging.request';
import { AuthService } from '../../../services/auth/auth.service';
import { InquireService } from '../../../services/inquire/inquire.service';
import { FiltersComponent } from '../filters/filters.component';
import { CreateOfferResponse } from 'src/app/models/create.offer.response';
import { TeamName } from 'src/app/models/team.name';
import { PackageService } from 'src/app/services/offer/package.service';
import { CreateBuyOfferRequest } from 'src/app/models/create.buy.request';
import { Router } from '@angular/router';
import { OfferStatusChangeRequest } from '../../../models/offer.status.change.request';
import { OfferStatus, enumFromStringValue } from 'src/app/models/OfferStatus';
import { Offer } from 'src/app/models/offer';

@Component({
  selector: 'app-inquire-list',
  templateUrl: './inquire-list.component.html',
  styleUrls: ['./inquire-list.component.css'],
})
export class InquireListComponent{

  @ViewChild('filterComponent') filterComponent!: FiltersComponent;

  showFiltersModal: boolean = false;
  showOffersModal: boolean = false;
  showStatusModal: boolean = false;

  createOfferResponses: CreateOfferResponse[] = [];
  createBuyOfferRequest: CreateBuyOfferRequest = new CreateBuyOfferRequest();
  currentInquireId: number = 0;

  onlyOffers: boolean = false;

  statuses = Object.keys(OfferStatus);

  @Input()
  set setOnlyOffers(value: boolean) {
    this.onlyOffers = value;
    this.pagingRequest.onlyOffers = this.onlyOffers;
    this.loadData();
  }

  pagingRequest: PagingRequest = {
    id: Number(this.authService.getId()),
    role: String(this.authService.getRole()),
    onlyOffers: this.onlyOffers,
    numberOfRows: 10,
    pageNumber: 1,
    filters: [], //[{ propertyName: "PackageSizeWidth", isInquireProperty: true, filterType: "Minimum", value: "10"}]
    sortFilter: null
  }

  pageNumbers: number[] = [];

  inquires: InquireWithOffer[] = [];
  inquireCount: number = 0;

  maxPageNumber: number = 0;

  createOfferResponse: CreateOfferResponse = new CreateOfferResponse();
  teamName: TeamName = TeamName.NONE;
  price: number = 0;
  
  role: string|null = this.authService.getRole();

  offerStatusChangeRequest: OfferStatusChangeRequest = new OfferStatusChangeRequest();

  constructor(private inquireService: InquireService,
    private authService: AuthService,
    private offerService: PackageService,
    private router: Router 
    ) {
  }
  

  isInEnum(status : string) : boolean
  {
    const st = enumFromStringValue<OfferStatus>(OfferStatus, status);
    if(st == undefined)
      return false;
    return true;
  }

  loadData() {
    this.inquireService.getInquires(this.pagingRequest)
      .subscribe({
        next: (inquireResponse) => {
          this.inquires = inquireResponse.inquires;
          this.inquireCount = inquireResponse.inquireCount;
          this.inquires = this.inquires.map(inquire => {
            const mappedInquire = Object.assign(new InquireWithOffer(), inquire);
            if (mappedInquire.sourceAddress != null)
              mappedInquire.sourceAddress = Object.assign(new Address(), inquire.sourceAddress);
            if (mappedInquire.destinationAddress != null)
              mappedInquire.destinationAddress = Object.assign(new Address(), inquire.destinationAddress);
            return mappedInquire;
          })
          this.maxPageNumber = Math.ceil(this.inquireCount / this.pagingRequest.numberOfRows);
          this.updatePageNumbers();
        },
        error: (response) => {
          console.log(response);
        }
      });
  }

  onPageChange(event: any) {
    let text = event.target.innerText;
    if (text == "First")
      this.pagingRequest.pageNumber = 1
    else if (text == "Last") {
      this.pagingRequest.pageNumber = this.maxPageNumber;
      console.log(this.pagingRequest.pageNumber)
    }
    else
      this.pagingRequest.pageNumber = Number(text);
    this.loadData();
  }

  updatePageNumbers() {
    let newPageNumbers: number[] = [];
    let indexUp: number = this.pagingRequest.pageNumber;
    let indexDown: number = this.pagingRequest.pageNumber - 1;
    while (newPageNumbers.length < 10 && (indexDown > 0 || indexUp <= this.maxPageNumber)) {
      if (indexDown > 0)
        newPageNumbers.push(indexDown);
      if (indexUp <= this.maxPageNumber)
        newPageNumbers.push(indexUp)
      indexDown--;
      indexUp++;
    }
    newPageNumbers.sort(this.compareNumbers);
    this.pageNumbers = newPageNumbers;
  }

  compareNumbers(a: number, b: number): number {
    return a - b;
  }

  resetFilters() {
    this.filterComponent.resetFilters();
  }

  onSearch() {
    this.closeModal();
    this.closeModal();
    const result = this.filterComponent.getFilters();

    if (result.sortFilter.sortOrder != "" && result.sortFilter.propertyName != "")
      this.pagingRequest.sortFilter = result.sortFilter;
    else
      this.pagingRequest.sortFilter = null;
    this.pagingRequest.filters = [];

    result.displayFilter.forEach(displayFilter => {
      if (displayFilter[0].filter.value != "")
        this.pagingRequest.filters.push(displayFilter[0].filter);
      if (displayFilter[1].filter.value != "")
        this.pagingRequest.filters.push(displayFilter[1].filter);
    })

    this.loadData();
  }

  buyOffer() {
    let userId = this.authService.getId();
    if (userId != null) {
      this.createBuyOfferRequest.userId = userId;
      this.createBuyOfferRequest.inquireId = this.currentInquireId;
      this.createBuyOfferRequest.teamName = TeamName.MiNIPackage;
      this.offerService.buyOffer(this.createBuyOfferRequest);
      setTimeout(() => {
        location.reload();
      }, 1000);
    }
  }

  getOffer(inquireId: number) {
    this.openOffersModal();
    this.offerService.getOwnOffer(inquireId);
    this.createOfferResponses = this.offerService.getOfferResponses();
  }

  //getAllOffers(inquireId: number) {
  //  this.currentInquireId = inquireId;
  //  this.openOffersModal();
  //  this.createOfferResponses = [];
  //  this.offerService.getAllOffers(inquireId);
  //  this.createOfferResponses = this.offerService.getOfferResponses();
  //}

  setInquireId(inquireId: number) {
    this.currentInquireId = inquireId;
    this.openOffersModal();
  }

  openOffersModal() {
    this.showOffersModal = true;
  }

  openFiltersModal() {
    this.showFiltersModal = true;
  }

  openStatusModal(inquire: InquireWithOffer) {
    this.offerStatusChangeRequest.offerStatus = inquire.offer.offerStatus;
    this.offerStatusChangeRequest.offerId = inquire.offer.offerId;
    this.showStatusModal = true;
  }

  closeModal() {
    this.showOffersModal = false;
    this.showFiltersModal = false;
    this.showStatusModal = false;
  }

  updateStatus() {
    console.log(this.role)
    this.offerService.updatePackageStatus(this.offerStatusChangeRequest).subscribe(
      (response) => {
        console.log('API response:', response);
      },
      (error) => {
        console.error('API error:', error);
      }
    );;
    setTimeout(() => {
      location.reload();
    }, 200);
  }
}
