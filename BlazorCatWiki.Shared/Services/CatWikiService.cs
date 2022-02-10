using BlazorCatWiki.Shared.Models;
using BlazorCatWiki.Shared.ServiceClients;

namespace BlazorCatWiki.Shared.Services
{
    public class CatWikiService : ICatWikiService
    {
        private readonly ICatServiceClient _client;
        private readonly IStorageService _storage;
        public CatWikiService(ICatServiceClient client, IStorageService storageService)
        {
            _client = client;
            _storage = storageService;
        }
        public async Task<IList<Breed>> GetBreeds()
        {
            var items = _storage.GetBreeds();
            if(items != null)
                return items;
            items = await _client.GetBreeds();
            _storage.SetBreeds(items);
            return items;
        }
        
        public async Task<Breed> GetBreed(string name)
        {
            var items = await GetBreeds();
            var breed = items.FirstOrDefault(i => i.Name == name);
            return breed;
        }

        public async Task<IEnumerable<Image>> GetImages(string breedId, int limit)
        {
            return await _client.GetImages(breedId, limit);
        }
    }
}
