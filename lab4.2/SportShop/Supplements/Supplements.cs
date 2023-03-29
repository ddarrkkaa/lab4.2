namespace SportShop.SportShop.Supplements;

public class Supplements : SportGoods
{
    public string Composition { get; set; }

    public Supplements(string type)
    {
        Type = type;
    }
    
    public class SupplementsPriceComparer : IComparer<Supplements>
    {
        public int Compare(Supplements x, Supplements y)
        {
            return y.Price.CompareTo(x.Price);
        }
    }

    public static void FindInDiapason(  List<Supplements>allSupplements, int From, int To)
    {
        List<Supplements> supplementsInRange = new List<Supplements>();
        foreach (Supplements supplement in allSupplements)
        {
            // Перевірка, чи вартість входить у діапазон
            if (supplement.Price >= From && supplement.Price <= To)
            {
                supplementsInRange.Add(supplement);
            }
        }
        foreach (Supplements supplement in supplementsInRange)
        {
            Console.WriteLine($"Name: {supplement.Name}, Price: {supplement.Price}");
        }
    }
}