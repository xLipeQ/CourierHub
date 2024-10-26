import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { AuthService } from '../services/auth/auth.service';
import { Router } from '@angular/router';
import { NotificationService } from '../services/notification/notification.service';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {

  constructor(
    private authService: AuthService,
    private router: Router,
    private notificationService: NotificationService
  ) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const token = this.authService.getToken();
    if(token) {
      request = request.clone({
        setHeaders: {Authorization: `bearer ${token}`}
      });
    }
    return next.handle(request).pipe(
      catchError(error => {
        if(error instanceof HttpErrorResponse) {
          if(error.status === 401){
            this.notificationService.notifyWarning("Invalid credentials", "Given username/email or password is incorrect", 5000, "topRight");
            this.router.navigate(['login']);
          }
          if(error.status === 403){
            this.notificationService.notifyWarning("Invalid authorization", "You don't have access to this service", 5000, "topRight");
            this.router.navigate(['login']);
          }
        }
        return throwError(() => new Error(error));
      })
    );
  }
}
