using BlazorCatWiki.Shared.Models;
using Refit;

namespace BlazorCatWiki.Shared.ServiceClients
{
    public interface ICatServiceClient
    {
        [Get("/breeds")]
        public Task<IList<Breed>> GetBreeds();

        [Get("/breeds/search")]
        public Task<Breed[]> GetBreed([AliasAs("q")]string name);

        [Get("/images/search?breed_id={breedId}&limit={limit}&order=random&size=med")]
        public Task<IEnumerable<Image>> GetImages(string breedId, int limit=9);
    }
}
