namespace SportShop.SportShop;

public class SportGoods
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public static void TypeSort(List<SportGoods> sgl)
    {
        Console.WriteLine("Shopping goods sorted by type:");
        var sorted = sgl.GroupBy(p => p.GetType());
        foreach (var type in sorted)
        {
            Console.WriteLine("----");
            foreach (SportGoods sportGoods in type)
            {
                Console.WriteLine(sportGoods.Type+" "+ sportGoods.Name);
            }
        }
        Console.WriteLine();
    }
    public class PriceComparer : IComparer<SportGoods>
    {
        public int Compare(SportGoods x, SportGoods y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    public static void PriceSort(List<SportGoods> sportGoods)
    {
        sportGoods.Sort(new PriceComparer());
        Console.WriteLine("Sort supplements by price from lowest to highest: \n");
        foreach (SportGoods sg in sportGoods)
        {
            Console.WriteLine( $"{sg.Type} {sg.Name} (price {sg.Price})");
        }
        Console.WriteLine(" ");
    }

}