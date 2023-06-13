using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class ElectricSuvFord : ElectricSuv, IFord
    {
        public ElectricSuvFord(Color color, double cost, double fuelCons)
                : base(Manufacturer.Ford, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Ford, electric Suv");
        }
    }
}
