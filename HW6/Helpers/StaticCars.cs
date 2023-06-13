using HW6.Domain;

namespace HW6.Helpers
{
    public static class StaticCars
    {
        public static Car[] FindByWeight(this Car[] cars, double minWeight, double maxWeight)
        {
            Car[] res = new Car[100];
            int count = 0;
            foreach (Car car in cars)
            {
                if (car.Cost >= minWeight && car.Cost <= maxWeight)
                {
                    res[count] = car;
                    count++;
                }
            }

            Array.Resize(ref res, count);
            return res;
        }

        public static void PrintList(this Car[] cars)
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
