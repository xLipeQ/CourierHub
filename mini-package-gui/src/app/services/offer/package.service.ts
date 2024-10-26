import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { Observable } from 'rxjs';
import { OfferStatDTO } from 'src/app/models/OfferStatus';
import { Inquire } from 'src/app/models/inquire';
import { CreateOfferResponse } from 'src/app/models/create.offer.response';
import { TeamName } from 'src/app/models/team.name';
import { OfferFactoryApiService } from '../offer-factory/offer-factory-api.service';
import { CreateOfferRequest } from 'src/app/models/create.offer.request';
import { CreateBuyOfferRequest } from 'src/app/models/create.buy.request';
import { NotificationService } from '../notification/notification.service';
import { AuthService } from '../auth/auth.service';
import { OfferStatusChangeRequest } from '../../models/offer.status.change.request';
import { Offer } from '../../models/offer';

@Injectable({
  providedIn: 'root'
})
export class PackageService {

  private apiUrl = environment.MiniPackage.url;
  offerResponses : CreateOfferResponse[] = [];
  offerId : number = 0;


  constructor(
    private httpClient : HttpClient,
    private offerApiService: OfferFactoryApiService,
    private notificationService: NotificationService,
    private authService: AuthService) { }

  getPackageStatus(globalId: string): Observable<OfferStatDTO> {
    return this.httpClient.get<OfferStatDTO>(`${this.apiUrl}/Offer/Status?GlobalId=${globalId}`);
  }

  getOfferResponses() : CreateOfferResponse[] {
    return this.offerResponses;
  }

  clearOfferResponses() {
    this.offerResponses = [];
  }

  buyOffer(request: CreateBuyOfferRequest) {
    this.offerApiService.buyOffer(request)
    .subscribe({
      next: (response) => {
          this.offerId = response;
          console.log(response);
          this.notificationService.notifySuccess("Offer bought", "Successfully bought an offer", 500, "bottomRight");
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

  getAllOffers(inquireId: number) {
    this.getOwnOffer(inquireId);
  }

  getOwnOffer(inquireId: number) {
      this.offerResponses = [];
      let request = new CreateOfferRequest(inquireId, TeamName.MiNIPackage);
      this.offerApiService.getIntOffer(request)
      .subscribe({
        next: (response) => {
          this.offerResponses.push(response);
        },
        error: (response) => {
          console.log(response);
        }
      });
  }

  updatePackageStatus(offerStatusChangeRequest: OfferStatusChangeRequest): Observable<Offer> {
    return this.httpClient.put<Offer>(`${this.apiUrl}/offer`, offerStatusChangeRequest);
  }
}
