export enum OfferStatus
{
    Rejected = "Rejected",
    AtWarehouse = "AtWarehouse",
    PickedByCourier = "PickedByCourier",
    OnTheWay = "OnTheWay",
    Delievered = "Delievered"
}

export class OfferStatDTO
{
    status : OfferStatus = OfferStatus.Rejected;
    mail : string = "";
    courierUsername : string = "";
    deliveryTime : Date = new Date();
}

export function enumFromStringValue<T> (enm: { [s: string]: T}, value: string): T | undefined {
    return (Object.values(enm) as unknown as string[]).includes(value)
      ? value as unknown as T
      : undefined;
  }

export function EnumToNumber(offerst : OfferStatus) : number 
{
    if(offerst == OfferStatus.Rejected)
        return 0;

    if(offerst == OfferStatus.AtWarehouse)
        return 1;

    if(offerst == OfferStatus.PickedByCourier)
        return 2;

    if(offerst == OfferStatus.OnTheWay)
        return 3;

    return 4;
}