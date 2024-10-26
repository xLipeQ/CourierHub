export class Filter {
  propertyName: string;
  isInquireProperty: boolean;
  filterType: string;
  value: string;

  constructor() {
    this.propertyName = "";
    this.isInquireProperty = true;
    this.filterType = "";
    this.value = "";
  }
}
