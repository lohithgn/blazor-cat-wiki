using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorCatWiki.Shared.Models;

namespace BlazorCatWiki.Shared.Services
{
    public interface IStorageService
    {
        public IList<Breed> GetBreeds();
        public void SetBreeds(IList<Breed> breeds);
    }
}
