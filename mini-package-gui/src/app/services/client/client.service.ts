import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Address } from '../../models/address';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient) { }

  getAllClientAddresses(clientId: number): Observable<Address[]> {
    return this.http.get<Address[]>(environment.MiniPackage.url + '/Client/addresses/' + clientId)
  }
}
