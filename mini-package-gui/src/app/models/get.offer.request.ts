import { Inquire } from "./inquire";

export class GetOfferRequest {
  inquire: Inquire;
  teamName: string;

  constructor() {
    this.inquire = new Inquire();
    this.teamName = "MiNIPackage"
  }
}
