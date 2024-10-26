import { Component, Input } from '@angular/core';
import { CreateOfferResponse } from 'src/app/models/create.offer.response';
import { CreateBuyOfferRequest } from 'src/app/models/create.buy.request';
import { TeamName } from 'src/app/models/team.name';
import { PackageService } from 'src/app/services/offer/package.service';
import { AuthService } from 'src/app/services/auth/auth.service';
import { ApiService } from '../../services/api/api.service';
import { CreateOfferRequest } from '../../models/create.offer.request';

@Component({
  selector: 'app-offer-item',
  templateUrl: './offer-item.component.html',
  styleUrls: ['./offer-item.component.css']
})
export class OfferItemComponent {
  createOfferResponse: CreateOfferResponse = new CreateOfferResponse();
  createBuyOfferRequest: CreateBuyOfferRequest = new CreateBuyOfferRequest();

  responses: CreateOfferResponse[] = [];
  @Input() inquireId: number = 0;

  constructor(private offerService: PackageService, private authService: AuthService, private apiService: ApiService) {
  }

  ngOnInit() {
    console.log(this.inquireId)
    if (this.inquireId != 0) {
      this.getOffers();
    }
  }

  //buyOffer() {
  //  let userId = this.authService.getId();
  //  if (userId != null) {
  //    this.createBuyOfferRequest.userId = userId;
  //    this.createBuyOfferRequest.inquireId = this.inquireId;
  //    this.createBuyOfferRequest.teamName = TeamName.MiNIPackage;
  //    this.offerService.buyOffer(this.createBuyOfferRequest);
  //    setTimeout(() => {
  //      location.reload();
  //    }, 1000);
  //  }
  //}

  //getOffer() {
  //  this.offerService.getAllOffers(this.inquireId);
  //  this.responses = this.offerService.getOfferResponses();
  //}

  getOffers() {
    let request = new CreateOfferRequest(this.inquireId, TeamName.NONE);
    for (const value in TeamName) {
      if (TeamName.hasOwnProperty(value)) {
        request.teamName = TeamName[value as keyof typeof TeamName]
        this.apiService.getOffer(request)
          .subscribe({
            next: (response) => {
              if (response) {
                this.responses.push(response)
              }
            },
            error: (response) => {
              console.log(response);
            }
          });
      }
    }
  }

  buyOffer(res: CreateOfferResponse) {
    let userId = this.authService.getId();
    console.log(userId)
    if (userId != null) {
      this.createBuyOfferRequest.userId = userId;
      this.createBuyOfferRequest.inquireId = this.inquireId;
      this.createBuyOfferRequest.inquirGuid = res.inquireGuid;
      this.createBuyOfferRequest.teamName = res.teamName;
      this.apiService.buyOffer(this.createBuyOfferRequest)
        .subscribe({
          next: (response) => {
            location.reload();
          },
          error: (response) => {
            console.log(response);
          }
        });
    }
  }
}
