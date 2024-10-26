import { Inquire } from "./inquire";
import { Offer } from "./offer";

export class InquireWithOffer extends Inquire {
  offer: Offer;

  constructor() {
    super();
    this.offer = new Offer();
  }
}
