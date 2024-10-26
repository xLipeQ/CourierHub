import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginRequest } from 'src/app/models/login.request.model';
import { LoginResponse } from 'src/app/models/login.response';
import { User } from 'src/app/models/user.model';
import { environment } from 'src/environments/environment.development';
import { NotificationService } from '../notification/notification.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { LoginGoogleRequest } from '../../models/login.request.google.model';
import { SocialAuthService } from "@abacritt/angularx-social-login";

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl: string = environment.MiniPackage.url;
  jwtHelper: JwtHelperService = new JwtHelperService();

  constructor(
    private http: HttpClient,
    private router: Router,
    private notificationService: NotificationService,
    private socialAuthService: SocialAuthService
  ) { }

  login(loginRequest: LoginRequest): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(this.baseUrl + '/auth/login', loginRequest);
  }

  loginGoogle(loginGoogleRequest: LoginGoogleRequest): Observable<LoginResponse> {
    return this.http.post<LoginResponse>(this.baseUrl + '/auth/loginGoogle', loginGoogleRequest);
  }

  register(user: User): Observable<User> {
    return this.http.post<User>(this.baseUrl + '/auth/register', user);
  }

  logout() {
    this.notificationService.notifySuccess("Logging out", "Successfully logged out", 5000, "topCenter")
    this.socialAuthService.signOut(true);
    localStorage.clear();
    this.router.navigate(['']);
  }

  storeToken(token: string) {
    localStorage.setItem("token", token);
  }

  getToken() {
    return localStorage.getItem("token");
  }

  getId(): number | null {
    let userId = this.getDecodedToken("Id");
    if (userId === null)
      return null;
    else {
      return Number.parseInt(userId);
    }
  }

  getRole(): string | null {
    return this.getDecodedToken("Role");
  }

  getUsername(): string | null {
    return this.getDecodedToken("Name");
  }

  storeLocalValue(key: string, value: string) {
    localStorage.setItem(key, value);
  }

  getLocalValue(key: string) {
    return localStorage.getItem(key);
  }

  isLoggedIn(): boolean {
    return !this.isGuest();
  }

  isClient(): boolean {
    return this.getRole()?.toLowerCase() === "client";
  }

  isOfficeWorker(): boolean {
    return this.getRole()?.toLowerCase() === "officeworker";
  }

  isCourier(): boolean {
    return this.getRole()?.toLowerCase() === "courier";
  }

  isGuest(): boolean {
    let role = this.getRole()?.toLowerCase();
    return role === "guest" || role === undefined;
  }

  getDecodedToken(claim: string): string | null {
    const token = this.getToken();
    if (token == null)
      return null;
    else {
      return this.jwtHelper.decodeToken(token)[claim];
    }
  }
}
