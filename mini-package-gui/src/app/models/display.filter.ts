import { Filter } from "./filter.model";

export class DisplayFilter {
  filter: Filter;
  displayName: string;

  constructor() {
    this.filter = new Filter();
    this.displayName = "";
  }
}
