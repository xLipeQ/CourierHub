export class Offer {
  offerId: number;
  price: number;
  teamName: string;
  offerStatus: string;

  constructor() {
    this.offerId = 0;
    this.price = 0;
    this.teamName = "";
    this.offerStatus = "";
  }
}
