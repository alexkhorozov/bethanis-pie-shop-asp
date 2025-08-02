namespace BethanysPieShop.Models;

public interface IPieRepository
{
    IEnumerable<Pie> AllPies { get; }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int pieId);
    //IEnumerable<Pie> GetPiesByCategory(string category);
    //void AddPie(Pie pie);
    //void UpdatePie(Pie pie);
    //void DeletePie(int pieId);

}
