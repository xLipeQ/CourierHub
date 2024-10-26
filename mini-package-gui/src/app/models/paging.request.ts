import { Filter } from "./filter.model";
import { SortFilter } from "./sort.filter";

export class PagingRequest {
  id  : number;
  role: string;
  onlyOffers: boolean;
  numberOfRows: number;
  pageNumber: number;
  filters: Filter[]
  sortFilter: SortFilter | null;

  constructor() {
    this.id = 0;
    this.role = "";
    this.onlyOffers = false;
    this.numberOfRows = 0;
    this.pageNumber = 0;
    this.filters = [];
    this.sortFilter = null;
  }
}
