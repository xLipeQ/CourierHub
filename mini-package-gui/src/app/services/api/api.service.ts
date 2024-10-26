import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment.development';
import { Observable } from 'rxjs/internal/Observable';
import { CreateOfferResponse } from '../../models/create.offer.response';
import { CreateOfferRequest } from '../../models/create.offer.request';
import { CreateBuyOfferRequest } from '../../models/create.buy.request';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(
    private httpClient: HttpClient) { }

  getOffer(createOfferRequest: CreateOfferRequest): Observable<CreateOfferResponse> {
    return this.httpClient.post<CreateOfferResponse>(environment.MiniPackage.url + '/Offer', createOfferRequest)
  }

  buyOffer(createBuyOfferRequest: CreateBuyOfferRequest): Observable<number> {
    return this.httpClient.post<number>(environment.MiniPackage.url + '/Offer/buy', createBuyOfferRequest)
  }
}
