using HW6.Enums;
using HW6.Interfaces;

namespace HW6.Domain
{
    public class ElectricSuvTesla : ElectricSuv, ITesla
    {
        public ElectricSuvTesla(Color color, double cost, double fuelCons)
                : base(Manufacturer.Tesla, color, cost, fuelCons)
        {
        }

        public void WhatIAm()
        {
            Console.WriteLine("I am a Tesla, electric Suv");
        }
    }
}