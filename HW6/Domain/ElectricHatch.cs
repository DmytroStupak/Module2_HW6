using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class ElectricHatch : ElectricCar, IElectricCar
    {
        public ElectricHatch(Manufacturer man, Color color, double cost, double fuelCons)
                : base(man, BodyType.Hatchback, color, cost, fuelCons)
        {
        }

        public ElectricHatch()
        {
        }

        public IFord GetFord()
        {
            return new ElectricHatchFord(Color.Blue, 25000, 0);
        }

        public IHyundai GetHyundai()
        {
            return new ElectricHatchHyundai(Color.Red, 20000, 0);
        }

        public INissan GetNissan()
        {
            return new ElectricHatchNissan(Color.Green, 15000, 0);
        }

        public ITesla GetTesla()
        {
            return new ElectricHatchTesla(Color.Blue, 50000, 0);
        }
    }
}
