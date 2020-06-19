using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Fennec.Contracts;
using Fluxor;

namespace Fennec.Client.Store.GetAdvertisements
{
    
    public class Effects
    {
        private readonly HttpClient _client;

        public Effects(HttpClient client)
        {
            _client = client;
        }

        [EffectMethod]
        public async Task HandleGetAdvertisementsAction(GetAdvertisementsAction action, IDispatcher dispatcher)
        {
            var advertisements =
                await _client.GetFromJsonAsync<ICollection<AdvertisementDto>>($"/advertisers/{action.AdvertiserId}/advertisements");
            dispatcher.Dispatch(new GetAdvertisementsResultAction(advertisements));
        }
    }
}