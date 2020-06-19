using System.Linq;
using Fennec.Contracts;
using Fluxor;

namespace Fennec.Client.Store.GetAdvertisements
{
    public class AdvertisementsFeature : Feature<AdvertisementsState>
    {
        public override string GetName()
        {
            return "Advertisements";
        }

        protected override AdvertisementsState GetInitialState()
        {
            return new AdvertisementsState(Enumerable.Empty<AdvertisementDto>().ToList());
        }
    }
}