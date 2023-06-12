using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class ElectricSuvNissan : ElectricSuv, INissan
    {
        public ElectricSuvNissan(Color color, double cost, double fuelCons)
                : base(Manufacturer.Nissan, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Nissan, electric Suv");
        }
    }
}