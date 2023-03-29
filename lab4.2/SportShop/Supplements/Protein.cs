namespace SportShop.SportShop.Supplements;

public class Protein : Supplements
{
    public double Capacity { get; }
    public Protein(string name, string composition, int price, double capacity):base(type: "Protein")
    {
        Name = name;
        Composition = composition;
        Price = price;
        Capacity = capacity;
    }   
}