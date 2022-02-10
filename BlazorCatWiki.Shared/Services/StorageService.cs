using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorCatWiki.Shared.Models;

namespace BlazorCatWiki.Shared.Services
{
    public class StorageService : IStorageService
    {
        private IList<Breed>? _breeds = null;    
        public IList<Breed> GetBreeds()
        {
            return _breeds!;
        }

        public void SetBreeds(IList<Breed> breeds)
        {
            _breeds = breeds;
        }
    }
}
