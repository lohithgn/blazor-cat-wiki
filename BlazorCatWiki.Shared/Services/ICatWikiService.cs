using BlazorCatWiki.Shared.Models;

namespace BlazorCatWiki.Shared.Services
{
    public interface ICatWikiService
    {
         public Task<IList<Breed>> GetBreeds();
         public Task<Breed> GetBreed(string name);
         public Task<IEnumerable<Image>> GetImages(string breedId, int limit=9);
    }
}
