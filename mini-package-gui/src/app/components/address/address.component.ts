import { Component, Input } from '@angular/core';
import { Address } from 'src/app/models/address';
import { Country } from 'src/app/models/country';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent {
  @Input() countries: Country[] = [];
  @Input() addresses: Address[] = [];
  @Input() title: string = "";
  @Input() showDate: boolean = false;
  @Input() isClientLogged: boolean = false;
  @Input() clientId: number = 0;

  date: Date = new Date();
  defaultAddress: Address = new Address();
  address: Address = this.defaultAddress;
  selectedAddress: Address = this.defaultAddress;

  onChange(selectedAddress: any): void {
    this.address = JSON.parse(JSON.stringify(selectedAddress));
    let newCountry = this.countries.find(country => country.countryId == selectedAddress.country.countryId)
    if (newCountry != undefined)
      this.address.country = newCountry;
    else
      this.address.country = null;
  }

  onCountryChange(selectedCountry: any): void {
    let newCountry = this.countries.find(country => country.countryId == selectedCountry.countryId)
    if (newCountry != undefined) {
      this.address.country = newCountry;
    }
    else {
      this.address.country = null;
    }
  }

  clearAddress(): void {
    this.address = this.defaultAddress;
    this.address.country = null;
  }

  getAddress() : [Address, Date] {
    return [this.address, this.date];
  }
}
