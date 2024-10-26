import { HttpClient, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { OfferFactoryService } from './offer-factory.service';
import { Observable, of, timeout } from 'rxjs';
import { CreateOfferRequest } from 'src/app/models/create.offer.request';
import { CreateOfferResponse } from 'src/app/models/create.offer.response';
import { CreateBuyOfferRequest } from 'src/app/models/create.buy.request';

@Injectable({
  providedIn: 'root'
})
export class OfferFactoryApiService {

  timeoutValue: number = 20000;

  constructor(
    private httpClient : HttpClient,
    private offerFactory: OfferFactoryService
    ) { }

    getIntOffer(request: CreateOfferRequest): Observable<any>  {
      let url = this.offerFactory.getUrl(request.teamName);
      if (url !== null) {
        let createOfferUrl = `${url}/offer/int/showOffer`;
        return this.httpClient.post<CreateOfferResponse>(createOfferUrl, request);
      }
      return of(null);
    }

    buyOffer(request: CreateBuyOfferRequest): Observable<any> {
      let url = this.offerFactory.getUrl(request.teamName);
      if (url !== null) {
        let buyOfferUrl = `${url}/offer/buy`;
        return this.httpClient.post<number>(buyOfferUrl, request)
          .pipe(
            timeout(this.timeoutValue)
            );
      }
      return of(null);
    }

}
