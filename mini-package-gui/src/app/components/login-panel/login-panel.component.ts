import { Component, HostListener } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Client } from '../../models/client.model';
import { LoginResponse } from '../../models/login.response';
import { User } from '../../models/user.model';
import { Employee } from '../../models/employee.model';
import { AuthService } from '../../services/auth/auth.service';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NotificationService } from '../../services/notification/notification.service';
import { LoginRequest } from '../../models/login.request.model';
import { UserService } from '../../services/user/user.service';
import { SocialAuthService } from "@abacritt/angularx-social-login";
import { SocialUser } from "@abacritt/angularx-social-login";
import { LoginGoogleRequest } from '../../models/login.request.google.model';

@Component({
  selector: 'app-login-panel',
  templateUrl: './login-panel.component.html',
  styleUrls: ['./login-panel.component.css'],
  providers: [
    UserService
  ]
})
export class LoginPanelComponent {

  user: User = new User();
  loginRequest: LoginRequest = new LoginRequest();
  loginResponse: LoginResponse = new LoginResponse();
  loginForm: FormGroup | null = null;

  userGoogle!: SocialUser;

  constructor(
    private authService: AuthService,
    private router: Router,
    private notificationService: NotificationService,
    private http: HttpClient,
    private socialAuthService: SocialAuthService
    ) {}

  ngOnInit() {
    this.socialAuthService.authState.subscribe((user) => {
      this.userGoogle = user;
      const loginGoogleRequest = new LoginGoogleRequest();
      loginGoogleRequest.email = user.email;
      loginGoogleRequest.firstName = user.firstName;
      loginGoogleRequest.lastName = user.lastName;
      this.authService.loginGoogle(loginGoogleRequest).subscribe({
        next: (response: LoginResponse) => {
          this.onLoginResponse(response)
        },
        error: (response: any) => {
          console.log(response);
        }
      });
    });
  }

  login(){
    // delete all white spaces from the beggining and the end
    this.loginRequest.email = this.loginRequest.email.trim();
    this.loginRequest.username = this.loginRequest.username.trim();
    this.loginRequest.password = this.loginRequest.password.trim();
    
    if(!this.validateUserCredentials(this.loginRequest)) return;

    let ret = null;
    this.loginRequest.isGuest = false;
    this.authService.login(this.loginRequest)
      .subscribe({
        next: (response: LoginResponse) => {
          ret = response;
          this.onLoginResponse(response)
        },
        error: (response: any) => {
          console.log(response);
        }
      });
    return ret;
  }

  onLoginResponse(response: LoginResponse) {
    this.loginResponse = response;
    this.authService.storeToken(this.loginResponse.token);

    if (this.loginResponse.user != null) {
      this.user = this.loginResponse.user;
      this.user.loggedIn = true;
    }

    if (this.authService.isLoggedIn()) {
      this.notificationService.notifySuccess("Logged in", "Successful login", 5000, "topCenter");
      this.router.navigate(['']);
    }
  }

  validateUserCredentials(loginRequest: LoginRequest) : boolean {
    if(loginRequest.password.length !== 0) {
      if(loginRequest.username.length !== 0 || loginRequest.email.length !== 0) {
        return true;
      }
    }
    this.notificationService.notifyError("Invalid credentials", "Please provide login or email and password!", 5000, "topCenter");
    return false;
  }
  
  loginAsGuest() {
    if(this.user.loggedIn) {
      this.router.navigate(['']);
      return;
    }

    this.loginRequest.username = "guest";
    this.loginRequest.isGuest = true;

    this.authService.login(this.loginRequest)
    .subscribe({
      next: (response: LoginResponse) => {
        this.user = response.user;
        this.authService.storeToken(response.token);
        this.user.loggedIn = true;
        if(this.authService.isGuest()) {
          this.notificationService.notifySuccess("Logged in", "Successfully logged in as guest", 5000, "topCenter");
          this.router.navigate(['']);
        }
      },
      error: (response: any) => {
        console.log(response);
      }
    });
  }

  @HostListener('document:keyup', ['$event'])
  onKeyUp(event: KeyboardEvent) {
    if (event.key === 'Enter') {
      this.login();
    }
  }

}
