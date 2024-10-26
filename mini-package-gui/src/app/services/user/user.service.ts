import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment.development';
import { Observable } from 'rxjs';
import { LoginResponse } from '../../models/login.response';
import { User } from '../../models/user.model';
import { AuthService } from '../auth/auth.service';
import { LoginRequest } from 'src/app/models/login.request.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl: string = environment.MiniPackage.url;

  constructor(private http: HttpClient, private authService: AuthService) { }

  getUserInfo(id: number): Observable<User> {
    return this.http.get<User>(this.baseUrl + `/users/${id}`);
  }

  login(loginRequest: LoginRequest): Observable<LoginResponse> {
    return this.authService.login(loginRequest);
  }
}
