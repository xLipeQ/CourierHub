import { Component, ViewChild } from '@angular/core';
import { Country } from '../../../models/country';
import { CountryService } from '../../../services/country/country.service';
import { Address } from 'src/app/models/address';
import { ClientService } from 'src/app/services/client/client.service';
import { Inquire } from 'src/app/models/inquire';
import { AddressComponent } from '../../address/address.component';
import { InquireService } from 'src/app/services/inquire/inquire.service';
import { AuthService } from '../../../services/auth/auth.service';
import { NotificationService } from '../../../services/notification/notification.service';
import { OfferItemComponent } from '../../offer-item/offer-item.component';

@Component({
  selector: 'app-create-inquire',
  templateUrl: './create-inquire.component.html',
  styleUrls: ['./create-inquire.component.css']
})
export class CreateInquireComponent {
  @ViewChild('sourceAddressComponent') sourceAddressComponent!: AddressComponent;
  @ViewChild('destinationAddressComponent') destinationAddressComponent!: AddressComponent;

  isClientLogged: boolean = this.authService.isLoggedIn();
  clientId: number = Number(this.authService.getId());
  offersVisible: boolean = false;
  inquireId: number = 0;

  width: number | null = null;
  height: number | null = null;
  length: number | null = null;
  weight: number | null = null;

  sourceAddress: string = "Source address";
  destinationAddress: string = "Destination address";

  countries: Country[] = [];
  inquire: Inquire = new Inquire();

  addresses: Address[] = [];

  areAddressesAvailable: boolean = false;

  constructor(private countryService: CountryService,
    private clientService: ClientService,
    private inquireService: InquireService,
    private authService: AuthService,
    private notificationService: NotificationService) {
  }

  ngOnInit(): void {
    if (!this.authService.isLoggedIn()) {
      this.areAddressesAvailable = true;
    }
    
    this.countryService.getAllCountries()
      .subscribe({
        next: (countries) => {
          this.countries = countries;
        },
        error: (response) => {
          console.log(response);
        }
      });
    this.clientService.getAllClientAddresses(this.clientId)
      .subscribe({
        next: (addresses) => {
          this.addresses = addresses;
          this.addresses = this.addresses.map((address => Object.assign(new Address(), address)))
          this.areAddressesAvailable = true
        },
        error: (response) => {
          console.log(response);
        }
      });
  }

  submit() {
    this.inquire.clientId = this.clientId;

    this.inquire.packageSizeWidth = Number(this.width);
    this.inquire.packageSizeHeight = Number(this.height);
    this.inquire.packageSizeLength = Number(this.length);
    this.inquire.weight = Number(this.weight);

    this.inquire.createdDate = new Date();

    const [sourceAddress, pickupDate] = this.sourceAddressComponent.getAddress();
    this.inquire.sourceAddress = sourceAddress;
    this.inquire.pickupDate = pickupDate

    const [destinationAddress, deliveryDate] = this.destinationAddressComponent.getAddress();
    this.inquire.destinationAddress = destinationAddress;
    this.inquire.deliveryDate = deliveryDate;

    this.inquireService.createInquire(this.inquire)
      .subscribe({
        next: (response) => {
          this.notificationService.notifySuccess("Inquire", "Successfully created inquire", 3000, "bottomRight");
          this.inquireId = response;
          this.offersVisible = true;
        },
        error: (response) => {
          console.log(response);
        }
      });
  }

  closeModal() {
    this.offersVisible = false;
  }
}
