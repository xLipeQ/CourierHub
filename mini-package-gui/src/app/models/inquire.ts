import { Address } from "./address";

export class Inquire {
  clientId: number;
  inquireId: number;
  packageSizeWidth: number;
  packageSizeHeight: number;
  packageSizeLength: number;
  weight: number;
  createdDate: Date;
  pickupDate: Date;
  deliveryDate: Date;
  destinationAddress: Address | null;
  sourceAddress: Address | null;
  priority: string;
  deliveryAtWeekend: boolean;
  isIncoming: boolean;
    
  constructor() {
    this.clientId = 0;
    this.inquireId = 0;
    this.packageSizeWidth = 0;
    this.packageSizeHeight = 0;
    this.packageSizeLength = 0;
    this.weight = 0;
    this.createdDate = new Date();
    this.pickupDate = new Date();
    this.deliveryDate = new Date();
    this.destinationAddress = null;
    this.sourceAddress = null;
    this.priority = "Low"
    this.deliveryAtWeekend = false;
    this.isIncoming = true;
    }
}
