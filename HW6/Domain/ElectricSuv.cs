using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class ElectricSuv : ElectricCar, IElectricCar
    {
        public ElectricSuv(Manufacturer man, Color color, double cost, double fuelCons)
                : base(man, BodyType.SUV, color, cost, fuelCons)
        {
        }

        public ElectricSuv()
        {
        }

        public IFord GetFord()
        {
            return new ElectricSuvFord(Color.Green, 31000, 0);
        }

        public IHyundai GetHyundai()
        {
            return new ElectricSuvHyundai(Color.Blue, 29000, 0);
        }

        public INissan GetNissan()
        {
            return new ElectricSuvNissan(Color.Green, 32000, 0);
        }

        public ITesla GetTesla()
        {
            return new ElectricSuvTesla(Color.Blue, 57000, 0);
        }
    }
}
