import { Country } from "./country";

export class Address {
  addressId: number;
  city: string;
  street: string;
  streetNumber: string;
  flatNumber: number | null;
  zipCode: string;
  country: Country | null;

  constructor() {
    this.addressId = 0;
    this.city = '';
    this.street = '';
    this.streetNumber = '';
    this.flatNumber = null;
    this.zipCode ='';
    this.country = null;
  }

  public get stringAddress() {
    let countryName = "";
    if (this.country != null && this.country != undefined)
      countryName = this.country.countryName + ' ';
    let flatNumber = "";
    if (this.flatNumber != null && this.flatNumber != undefined)
      flatNumber = '/' + this.flatNumber.toString();
    return `${countryName}${this.city} ${this.street} ${this.streetNumber}${flatNumber} ${this.zipCode}`
  }
}
