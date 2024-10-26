import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Inquire } from '../../models/inquire';
import { Observable } from 'rxjs';
import { PagingRequest } from '../../models/paging.request';
import { InquireWithOfferResponse } from '../../models/inquire.with.offer.response';

@Injectable({
  providedIn: 'root'
})
export class InquireService {

  constructor(private http: HttpClient) { }

  createInquire(inquireRequest: Inquire): Observable<number> {
    return this.http.post<number>(environment.MiniPackage.url + '/Inquire', inquireRequest)
  }

  getInquires(pagingRequest: PagingRequest): Observable<InquireWithOfferResponse> {
    console.log(pagingRequest)
    return this.http.post<InquireWithOfferResponse>(environment.MiniPackage.url + '/inquire/inquires', pagingRequest)
  }
}
