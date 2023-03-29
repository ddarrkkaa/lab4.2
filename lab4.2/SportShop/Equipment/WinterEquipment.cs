namespace SportShop.SportShop.Equipment;

public class WinterEquipment : Equipment
{
    public bool Heavy { get; }
    public WinterEquipment(string type, string name, int price, bool heavy ):base(season: "Winter")
    {
        Type = type;
        Name = name;
        //Season = season;
        Price = price;
        Heavy = heavy;
    }
}