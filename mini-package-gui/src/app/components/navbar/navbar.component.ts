import { Component } from '@angular/core';
import { User } from '../../models/user.model';
import { AuthService } from '../../services/auth/auth.service';
import { Router } from '@angular/router';
import { UserService } from '../../services/user/user.service';
import { LoginRequest } from '../../models/login.request.model';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {

  user: User = new User();

  constructor(
    private userService: UserService, 
    private authService: AuthService,
    private router: Router
    ) {}  

  getUserInfo(id: number) {
    this.userService.getUserInfo(id)
    .subscribe({
      next: (res) => {
        this.user = res;
        console.log(this.user);
      },
      error: (res) => {
        console.log(res);
      }
    });
  }

  isLoggedIn(): boolean {
    return this.authService.isLoggedIn();
  }

  isClientOrGuest(): boolean {
    return this.isClient() || this.isGuest();
  }

  isClient(): boolean {
    return this.authService.isClient();
  }

  isGuest(): boolean {
    return this.authService.isGuest();
  }

  goToCreateInquire() {
    const role = this.authService.getRole()?.toLowerCase();
    if(role == 'guest' || role == 'client') {
      this.router.navigate(['createInquire']);
    }
    else if (role === undefined) {
      let loginRequest = new LoginRequest();
      loginRequest.isGuest = true;
      this.authService.login(loginRequest).subscribe({
        next: (res) => {
          this.authService.storeToken(res.token);
          this.router.navigate(['createInquire']);
        },
        error: (err) => {
          console.log(err);
        }
      });
      
    }
    else {
      this.router.navigate(['login']);
    }
  }

  getUserProfile() {
    if(this.isLoggedIn()) {
      this.router.navigate(['']);
    }
    else {
      this.router.navigate(['login']);
    }
  }

  getLoginScreen() {
    if(!this.isLoggedIn()) {
      this.router.navigate(['login']);
    }
    else {
      this.router.navigate(['']);
    }
  }

  getStatusScreen()
  {
    this.router.navigate(['status']);
  }

  logout() {
    if(this.isLoggedIn()) {
      this.authService.logout();
    }
  }

  getUserRole() {
    return this.authService.getRole()?.toLowerCase();
  }
}
