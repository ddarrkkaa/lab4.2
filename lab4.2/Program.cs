using SportShop.SportShop;
using SportShop.SportShop.Equipment;
using SportShop.SportShop.Supplements;

namespace SportShop
{
    public class  Program
    {
        static void Main()
        {
            List<Supplements> supplementsList = new List<Supplements>();
            supplementsList.Add(new Protein("BeastPink", "soy protein", 800, 0.5));
            supplementsList.Add(new Protein("Whey", "amino acids", 1569, 0.8));
            supplementsList.Add(new Vitamin("GymBeat", "vitamin Е", 200, true));
            supplementsList.Add(new Vitamin("Opti-Men", "multivitamin", 1200, true));
            
            List<Equipment> equipmentList = new List<Equipment>();
            equipmentList.Add(new SummerEquipment("Bike","CoolBike",  15000, "Green"));
            equipmentList.Add(new WinterEquipment("Ski","CoolSki",12000, false));
            equipmentList.Add(new SummerEquipment("Bike", "GoodBike", 2900, "Blue"));
            equipmentList.Add(new WinterEquipment("Ski","GoodSki", 1500, true));
            
            Equipment.SeasonSort(equipmentList);
            
            List<SportGoods> sportGoodsList = new List<SportGoods>();
            sportGoodsList.AddRange(equipmentList);
            sportGoodsList.AddRange(supplementsList);
            
            SportGoods.TypeSort(sportGoodsList);
            SportGoods.PriceSort(sportGoodsList);
            
            Console.WriteLine("Enter the diapason from:");
            int from = Int32.Parse(Console.ReadLine());
            Console.WriteLine("to:");
            int to = Int32.Parse(Console.ReadLine());
            Supplements.FindInDiapason(supplementsList, from, to);
        }

    }

}

