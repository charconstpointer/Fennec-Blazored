using System.Collections.Generic;
using Fennec.Contracts;

namespace Fennec.Client.Store.GetAdvertisements
{
    public class GetAdvertisementsResultAction
    {
        public GetAdvertisementsResultAction(ICollection<AdvertisementDto> advertisement)
        {
            Advertisement = advertisement;
        }

        public ICollection<AdvertisementDto> Advertisement { get; }
    }
}