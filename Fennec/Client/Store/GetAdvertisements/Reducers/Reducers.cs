using Fluxor;

namespace Fennec.Client.Store.GetAdvertisements.Reducers
{
    public class Reducers
    {
        [ReducerMethod]
        public static AdvertisementsState ReduceGetArticlesResultAction(AdvertisementsState state,
            GetAdvertisementsResultAction action)
            => new AdvertisementsState(action.Advertisement);
    }
}