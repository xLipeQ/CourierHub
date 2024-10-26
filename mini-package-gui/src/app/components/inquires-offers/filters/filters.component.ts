import { Component, Input } from '@angular/core';
import { Filter } from '../../../models/filter.model';
import { DisplayFilter } from '../../../models/display.filter';
import { SortFilter } from '../../../models/sort.filter';

@Component({
  selector: 'app-filters',
  templateUrl: './filters.component.html',
  styleUrls: ['./filters.component.css']
})
export class FiltersComponent {

  filters: DisplayFilter[][] = [];

  sortFilter: SortFilter = new SortFilter();

  @Input() onlyOffers: boolean = false;

  ngOnInit() {
    this.resetFilters()
  }

  resetFilters() {
    this.sortFilter = new SortFilter();
    this.filters = [
      [{ filter: { propertyName: "PackageSizeWidth", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Width" },
      { filter: { propertyName: "PackageSizeWidth", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "PackageSizeHeight", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Height" },
      { filter: { propertyName: "PackageSizeHeight", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "PackageSizeLength", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Length" },
      { filter: { propertyName: "PackageSizeLength", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "Weight", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Weight" },
      { filter: { propertyName: "Weight", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "CreatedDate", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Created" },
      { filter: { propertyName: "CreatedDate", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "PickupDate", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Pickup" },
      { filter: { propertyName: "PickupDate", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "DeliveryDate", filterType: "Minimum", isInquireProperty: true, value: "" }, displayName: "Delivery" },
        { filter: { propertyName: "DeliveryDate", filterType: "Maximum", isInquireProperty: true, value: "" }, displayName: "" }],
      [{ filter: { propertyName: "DeliveryAtWeekend", filterType: "Equals", isInquireProperty: true, value: "" }, displayName: "Weekend" },
        new DisplayFilter()],
      [{ filter: { propertyName: "Priority", filterType: "Equals", isInquireProperty: true, value: "" }, displayName: "Priority" },
      new DisplayFilter()]
    ];

    if (this.onlyOffers) {
      this.filters.push(
        [{ filter: { propertyName: "Price", filterType: "Minimum", isInquireProperty: false, value: "" }, displayName: "Price" },
        { filter: { propertyName: "Price", filterType: "Maximum", isInquireProperty: false, value: "" }, displayName: "" }],
        [{ filter: { propertyName: "TeamName", filterType: "Equals", isInquireProperty: false, value: "" }, displayName: "Team" },
        new DisplayFilter()],
        [{ filter: { propertyName: "OfferStatus", filterType: "Equals", isInquireProperty: false, value: "" }, displayName: "Status" },
        new DisplayFilter()])
    }
  }

  getFilters(): { sortFilter: SortFilter, displayFilter: DisplayFilter[][] } {
    if (["Price", "TeamName", "OfferStatus"].includes(this.sortFilter.propertyName))
      this.sortFilter.isInquireProperty = false;
    return { sortFilter: this.sortFilter, displayFilter: this.filters };
  }
}
