namespace SportShop.SportShop.Equipment;

public class SummerEquipment : Equipment
{
    public string Color { get;}
    public SummerEquipment(string type, string name, int price, string color ):base(season:"Summer")
    {
        Type = type;
        Name = name;
        Price = price;
        Color = color;
    }
}
