using BlazorCatWiki.Shared.Models;
using BlazorCatWiki.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorCatWiki.Pages
{
    public partial class Top
    {
		[Inject]
		public ICatWikiService Service { get; set; }
		
		bool _isBusy;
		Breed[] _breeds = Array.Empty<Breed>(); 

		protected override async Task OnInitializedAsync()
		{
			_isBusy = true;
			_breeds = (await Service.GetBreeds()).Take(10).ToArray();
			_isBusy = false;
		}
	}
}
