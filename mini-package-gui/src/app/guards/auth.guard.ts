import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router';
import { AuthService } from '../services/auth/auth.service';

export const authLoggedInUser: CanActivateFn = (route, state) => {
  return inject(AuthService).isLoggedIn();
};

export const authClient: CanActivateFn = (route, state) => {
  return inject(AuthService).isClient();
};

export const authOfficeWorker: CanActivateFn = (route, state) => {
  return inject(AuthService).isOfficeWorker();
};

export const authCourier: CanActivateFn = (route, state) => {
  return inject(AuthService).isCourier();
};

export const authGuest: CanActivateFn = (route, state) => {
  return inject(AuthService).isGuest();
}

export const authGuestOrClient: CanActivateFn = (route, state) => {
  let auth = inject(AuthService);
  return auth.isGuest() || auth.isClient();
}

export const authInquire: CanActivateFn = (route, state) => {
  return inject(AuthService).isClient() || inject(AuthService).isOfficeWorker();
};
