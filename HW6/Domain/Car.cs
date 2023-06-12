using HW6.Enums;

namespace HW6.Domain
{
    public abstract class Car : IComparable<Car>
    {
        private double _cost;
        private double _fuelConsumation;
        public Car(Manufacturer man, FuelType fuelType, BodyType type, Color color, double cost, double fuelCons)
        {
            Manufacturer = man;
            BodyType = type;
            Cost = cost;
            FuelConsumtion = fuelCons;
            FuelType = fuelType;
            Color = color;
        }

        public Car()
        {
        }

        public BodyType BodyType { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public double Cost
        {
            get => _cost;
            set => _cost = value > 0 ? value : 0;
        }

        public double FuelConsumtion
        {
            get => _fuelConsumation;
            set => _fuelConsumation = value > 0 ? value : 0;
        }

        public FuelType FuelType { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer}  {BodyType}  {FuelType}  {Cost}$  {FuelConsumtion}   liter/100km";
        }

        public int CompareTo(Car? other)
        {
            if (other is null)
            {
                throw new ArgumentException("Incorrect parameter value");
            }

            return FuelConsumtion.CompareTo(other.FuelConsumtion);
        }
    }
}