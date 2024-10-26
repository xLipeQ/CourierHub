import { InquireWithOffer } from "./inquire.with.offer";

export class InquireWithOfferResponse {
  inquires: InquireWithOffer[]
  inquireCount: number;

  constructor() {
    this.inquires = [];
    this.inquireCount = 0;
  }
}
