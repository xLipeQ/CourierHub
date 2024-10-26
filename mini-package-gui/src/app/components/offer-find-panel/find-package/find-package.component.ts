import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EnumToNumber, OfferStatDTO, OfferStatus, enumFromStringValue } from 'src/app/models/OfferStatus';
import { NotificationService } from 'src/app/services/notification/notification.service';
import { PackageService } from 'src/app/services/offer/package.service';

@Component({
  selector: 'app-find-package',
  templateUrl: './find-package.component.html',
  styleUrls: ['./find-package.component.css']
})
export class FindPackageComponent implements OnInit {
  
  courierName : string = "";
  courierMail : string = "";
  deliveryDate : string = "";
  status : OfferStatus | undefined = OfferStatus.AtWarehouse  ;
  otherstatus : string = "";
  statusType = OfferStatus;
  guid : string = "";

  shouldShow : boolean | null= false;
  isRightEnum : boolean = false;

  constructor(private packageservice: PackageService,
    private notificationService : NotificationService,
    private route: ActivatedRoute){}

  ngOnInit(): void {
    this.route.queryParams.subscribe((params) => {
      const globalId = params['GlobalId'];
      if (globalId) {
        this.getPackageInfo(globalId);
      }
    });
  }

  checkActive(MyMaxStatus : OfferStatus) : boolean
  {
    if(this.status == undefined)
      return false;
    return EnumToNumber(this.status) >= EnumToNumber(MyMaxStatus); 
  }

  goBack()
  {
    this.guid = "";
    this.shouldShow = false;
    this.isRightEnum = false;
    this.status = undefined;
    this.courierMail = "";
    this.courierName = "";
    this.deliveryDate = "";
  }

  getPackageInfo(id : string)
  {
    this.packageservice.getPackageStatus(id).subscribe({
      next: (res) => {
        if(res == null)
            this.notificationService.notifyError("Order Id", "This id does not exist", 3000, "bottomRight")
        this.courierMail = res.mail;
        this.guid = id;
        this.courierName = res.courierUsername;
        this.deliveryDate = res.deliveryTime.toString().substring(0,10);
        this.status = enumFromStringValue<OfferStatus>(OfferStatus, res.status);
        this.otherstatus = res.status;
        if(this.status != undefined)
          this.isRightEnum = true;
        console.log(res);
        this.shouldShow = true;
      },
      error: (res) => {
        this.shouldShow = false;
        this.notificationService.notifyError("Order Id", "This id does not exist", 3000, "bottomRight")
        console.log(res);
      }
    });
  }

}
