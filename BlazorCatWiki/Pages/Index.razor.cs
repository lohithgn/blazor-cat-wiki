using BlazorCatWiki.Shared.Models;
using BlazorCatWiki.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorCatWiki.Pages;

public partial class Index
{
    [Inject]
    public ICatWikiService Service { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    IList<Breed> _breeds = new List<Breed>();
    IList<Breed> _mostSearchedBreeds = new List<Breed>(); 
    IList<Breed> _randomBreeds = new List<Breed>(); 

    bool _isBusy;
    protected override async Task OnInitializedAsync()
    {
        _isBusy = true;
        var breeds =  await Service.GetBreeds();
        _breeds = breeds;
        PrepareMostSearchedBreeds(_breeds);
        PrepareRandomBreeds(_breeds);
        _isBusy = false;
    }

    public void OnBreedSelect(ChangeEventArgs args)
    {
        var uri = $"/breed/{args?.Value.ToString()}";
        NavigationManager.NavigateTo(uri);
    }

    private void PrepareRandomBreeds(IList<Breed> source)
    {
        _randomBreeds = GetRandomItemsFromArray(source, 3);
    }

    private void PrepareMostSearchedBreeds(IList<Breed> source)
    {
        _mostSearchedBreeds = GetRandomItemsFromArray(source, 4);
    }
    
    private List<Breed> GetRandomItemsFromArray(IList<Breed> source, int itemCount)
    {
        var max = source.Count();
        Random rnd = new Random();
        List<Breed> breeds = new List<Breed>();
        for (var counter = 0; counter < itemCount; counter++)
        {
            breeds.Add(source[rnd.Next(0, max)]);
        }
        return breeds;
    }
    
}
