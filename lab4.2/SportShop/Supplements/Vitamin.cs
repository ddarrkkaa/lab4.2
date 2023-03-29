namespace SportShop.SportShop.Supplements;

public class Vitamin : Supplements
{
    public bool TakeEveryDay { get;}
    public Vitamin(string name, string composition, int price, bool takeEveryDay):base(type:"Vitamin")
    {
        Name = name;
        Composition = composition;
        Price = price;
        TakeEveryDay = takeEveryDay;
    }
}