using HW6.Enums;

namespace HW6.Domain
{
    public abstract class GasCar : Car
    {
        public GasCar(Manufacturer man, BodyType type, Color color, double cost, double fuelCons)
            : base(man, FuelType.Gas, type, color, cost, fuelCons)
        {
        }

        public GasCar()
        {
        }
    }
}
