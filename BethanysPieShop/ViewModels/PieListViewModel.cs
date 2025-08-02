using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels;

public class PieListViewModel
{
    public string? CurrentCategory { get; set; }
    public IEnumerable<Pie> Pies { get; set; }


    public PieListViewModel(string? currentCategory, IEnumerable<Pie> pies)
    {
        Pies = pies;
        CurrentCategory = currentCategory;
    }
}
