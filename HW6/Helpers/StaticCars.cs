using HW6.Domain;

namespace HW6.Helpers
{
    public static class StaticCars
    {
        public static List<Car> FindByWeight(this List<Car> cars, double minWeight, double maxWeight)
        {
            List<Car> list = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Cost >= minWeight && car.Cost <= maxWeight)
                {
                    list.Add(car);
                }
            }

            return list;
        }

        public static void PrintList(this List<Car> cars)
        {
            double res = 0;
            Console.WriteLine("########################################################");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
                res += item.Cost;
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Fleet cost : {res} $");
            Console.WriteLine(" ");
            Console.WriteLine("########################################################");
        }
    }
}
