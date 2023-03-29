namespace SportShop.SportShop.Equipment;

public class Equipment : SportGoods
{
    public string Season { get; }
    public Equipment(string season)
    {
        Season = season;
    }
    
    public static void SeasonSort(List<Equipment> sgl)
    {
        Console.WriteLine("Shopping goods sorted by season:");
        var sorted = sgl.GroupBy(p => p.Season);
        foreach (var type in sorted)
        {
            Console.WriteLine($"----");
            foreach (Equipment sportGoods in type)
            {
                Console.WriteLine(sportGoods.Season +" "+ sportGoods.Name);
            }
        }
        Console.WriteLine();
    }

}