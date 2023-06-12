using HW6.Domain;
using HW6.Interfaces;

namespace Module2HW6
{
    public class TaxiDepot
    {
        private Car[] _cars = new Car[1];
        private int _count = 0;

        public TaxiDepot()
        {
            IElectricCar electricCarHatch = new ElectricHatch();
            IElectricCar electricCarSedan = new ElectricSedan();
            IElectricCar electricCarSuv = new ElectricSuv();
            IGasCar gasCarHatch = new GasHatch();
            IGasCar gasCarSedan = new GasSedan();
            IGasCar gasCarSuv = new GasSuv();
            AddCar((Car)electricCarHatch.GetFord());
            AddCar((Car)gasCarHatch.GetHyundai());
            AddCar((Car)electricCarSuv.GetTesla());
            AddCar((Car)gasCarSedan.GetFord());
            AddCar((Car)electricCarSedan.GetHyundai());
            AddCar((Car)gasCarSuv.GetNissan());
        }

        public Car[] GetCars() => _cars;
        public void AddCar(Car car)
        {
            if (_count <= _cars.Length)
            {
                Array.Resize(ref _cars, _count + 1);
            }

            _cars[_count] = car;
            _count++;
        }
    }
}
