using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class GasHatchFord : GasHatch, IFord
    {
        public GasHatchFord(Color color, double cost, double fuelCons)
                : base(Manufacturer.Ford, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Ford, gas hatchback");
        }
    }
}