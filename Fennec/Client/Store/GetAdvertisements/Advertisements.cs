using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Fennec.Client.Store.GetAdvertisements
{
    public class Advertisements
    {
        [Inject] public IState<AdvertisementsState> ArticlesState { get; set; }
        [Inject] public IDispatcher Dispatcher { get; set; }
    }
}