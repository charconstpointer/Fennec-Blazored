using System;

namespace Fennec.Client.Store.GetAdvertisements
{
    public class GetAdvertisementsAction
    {
        public Guid AdvertiserId { get;}

        public GetAdvertisementsAction(Guid advertiserId)
        {
            AdvertiserId = advertiserId;
        }
    }
}