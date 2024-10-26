import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPanelComponent } from './components/login-panel/login-panel.component';
import { authClient, authCourier, authGuest, authGuestOrClient, authLoggedInUser, authOfficeWorker, authInquire } from './guards/auth.guard';
import { CreateInquireComponent } from './components/client/create-inquire/create-inquire.component';
import { FindPackageComponent } from './components/offer-find-panel/find-package/find-package.component';
import { LandingPageComponent } from './components/mainpage/landing-page/landing-page.component';
import { InquiresComponent } from './components/inquires/inquires.component';
import { OffersComponent } from './components/offers/offers.component';

const routes: Routes = [
  { path: 'login', component: LoginPanelComponent },
  {
    path: 'createInquire',
    component: CreateInquireComponent,
    canActivate: [authGuestOrClient]
  },
  {
    path: 'inquires',
    component: InquiresComponent,
    canActivate: [authInquire]
  },
  {
    path: 'offers',
    component: OffersComponent,
    canActivate: [authLoggedInUser]
  },
  {
    path: 'status',
    component: FindPackageComponent
  },
  {
    path: '',
    component: LandingPageComponent
  },
  {
    path: '**',
    redirectTo: ''
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
