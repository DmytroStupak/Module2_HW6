using HW6.Enums;

namespace HW6.Domain
{
    public class ElectricCar : Car
    {
        public ElectricCar(Manufacturer man, BodyType type, Color color, double cost, double fuelCons)
            : base(man, FuelType.Electric, type, color, cost, fuelCons)
        {
        }

        public ElectricCar()
        {
        }
    }
}
