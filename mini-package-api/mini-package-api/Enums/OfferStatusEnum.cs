namespace mini_package_api.Enums
{
    public enum OfferStatusEnum
    {
        None,
        Rejected,
        AtWarehouse,
        PickedByCourier,
        OnTheWay,
        Delivered
    }


    public static class OfferStatusEnumConverter
    {
        public static OfferStatusEnum ToEnum(string offer)
        {
            switch (offer.ToLower())
            {
                default: 
                    return OfferStatusEnum.None;
                case "rejected":
                    return OfferStatusEnum.Rejected;
                case "atwarehouse":
                    return OfferStatusEnum.AtWarehouse;
                case "pickedbycourier":
                    return OfferStatusEnum.PickedByCourier;
                case "ontheway":
                    return OfferStatusEnum.OnTheWay;
                case "delivered":
                    return OfferStatusEnum.Delivered;
            }
        }

        public static string ToString(OfferStatusEnum offer) 
        {
            return offer.ToString();
        }
    }
}
