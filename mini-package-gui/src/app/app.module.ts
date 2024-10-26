import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { LoginPanelComponent } from './components/login-panel/login-panel.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CreateInquireComponent } from './components/client/create-inquire/create-inquire.component';
import { AddressComponent } from './components/address/address.component';

import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NgToastModule } from 'ng-angular-popup';
import { TokenInterceptor } from './interceptor/token.interceptor';
import { InquireListComponent } from './components/inquires-offers/inquire-list/inquire-list.component';
import { InquiresComponent } from './components/inquires/inquires.component';
import { OffersComponent } from './components/offers/offers.component';
import { FiltersComponent } from './components/inquires-offers/filters/filters.component';
import { LandingPageComponent } from './components/mainpage/landing-page/landing-page.component';
import { FindPackageComponent } from './components/offer-find-panel/find-package/find-package.component';
import { OfferItemComponent } from './components/offer-item/offer-item.component';
import { SocialLoginModule, SocialAuthServiceConfig } from '@abacritt/angularx-social-login';
import { GoogleLoginProvider } from '@abacritt/angularx-social-login';
import { GoogleSigninButtonModule } from '@abacritt/angularx-social-login';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginPanelComponent,
    CreateInquireComponent,
    FindPackageComponent,
    AddressComponent,
    LandingPageComponent,
    AddressComponent,
    InquiresComponent,
    InquireListComponent,
    OffersComponent,
    FiltersComponent,
    OfferItemComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    NgToastModule,
    SocialLoginModule,
    GoogleSigninButtonModule,
  ],

  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true
    },
    {
      provide: 'SocialAuthServiceConfig',
      useValue: {
        autoLogin: false,
        providers: [
          {
            id: GoogleLoginProvider.PROVIDER_ID,
            provider: new GoogleLoginProvider(
              '363146141123-j2mr49mt780fj1pdm6dnb6mtqkve16u8.apps.googleusercontent.com'
            )
          }
        ],
        onError: (err) => {
          console.error(err);
        }
      } as SocialAuthServiceConfig,
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
