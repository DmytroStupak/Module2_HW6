using HW6.Helpers;
using Module2HW6;

namespace HW6
{
    public static class Starter
    {
        public static void Run()
        {
            TaxiDepot taxiDepot = new TaxiDepot();
            Console.WriteLine("Car park before sorting");
            taxiDepot.GetCars().PrintList();
            Console.WriteLine("Car search from $10,000 to $30,000");
            taxiDepot.GetCars().FindByWeight(10000, 30000).PrintList();
            Console.WriteLine("Sort cars by fuel consumption");
            taxiDepot.GetCars().Sort();
            taxiDepot.GetCars().PrintList();
            Console.WriteLine("Sorting cars by cost");
            taxiDepot.GetCars().Sort(new CompareCar());
            taxiDepot.GetCars().PrintList();
        }
    }
}
