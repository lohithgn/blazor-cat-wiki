using BlazorCatWiki.Shared.Models;
using BlazorCatWiki.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorCatWiki.Pages;

public partial class BreedDetails
{
    [Parameter]
    public string BreedName { get; set; }

    [Inject]
    public ICatWikiService Service { get; set; }

    IEnumerable<Image> _images = Enumerable.Empty<Image>();
    Breed _breed = null;
    bool _isBusy;
    protected override async Task OnInitializedAsync()
    {
        _isBusy = true;
        _breed = (await Service.GetBreed(BreedName));
        _images = await Service.GetImages(_breed.Id);
        _isBusy = false;
    }
}
