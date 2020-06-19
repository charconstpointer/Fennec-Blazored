using System.Collections.Generic;
using Fennec.Contracts;

namespace Fennec.Client.Store.GetAdvertisements
{
    public class AdvertisementsState
    {
        public AdvertisementsState(ICollection<AdvertisementDto> advertisements)
        {
            Advertisements = advertisements;
        }

        public ICollection<AdvertisementDto> Advertisements { get; private set; }
    }
}