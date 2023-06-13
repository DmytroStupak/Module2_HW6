using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class GasHatch : GasCar, IGasCar
    {
        public GasHatch(Manufacturer man, Color color, double cost, double fuelCons)
            : base(man, BodyType.Hatchback, color, cost, fuelCons)
        {
        }

        public GasHatch()
        {
        }

        public IFord GetFord()
        {
            return new GasHatchFord(Color.Blue, 27000, 8);
        }

        public IHyundai GetHyundai()
        {
            return new GasHatchHyundai(Color.Red, 25000, 7.5);
        }

        public INissan GetNissan()
        {
            return new GasHatchNissan(Color.Green, 26000, 6);
        }
    }
}
