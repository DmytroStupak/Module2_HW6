using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class GasSuv : GasCar, IGasCar
    {
        public GasSuv(Manufacturer man, Color color, double cost, double fuelCons)
            : base(man, BodyType.SUV, color, cost, fuelCons)
        {
        }

        public GasSuv()
        {
        }

        public IFord GetFord()
        {
            return new GasSuvFord(Color.Blue, 31000, 12);
        }

        public IHyundai GetHyundai()
        {
            return new GasSuvHyundai(Color.Red, 29500, 10);
        }

        public INissan GetNissan()
        {
            return new GasSuvNissan(Color.Blue, 28400, 15);
        }
    }
}