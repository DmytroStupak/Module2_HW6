using HW6.Domain;
using HW6.Interfaces;

namespace Module2HW6
{
    public class TaxiDepot
    {
        private List<Car> _cars = new List<Car>();

        public TaxiDepot()
        {
            IElectricCar electricCarHatch = new ElectricHatch();
            IElectricCar electricCarSedan = new ElectricSedan();
            IElectricCar electricCarSuv = new ElectricSuv();
            IGasCar gasCarHatch = new GasHatch();
            IGasCar gasCarSedan = new GasSedan();
            IGasCar gasCarSuv = new GasSuv();
            _cars.Add((Car)electricCarHatch.GetFord());
            _cars.Add((Car)gasCarHatch.GetHyundai());
            _cars.Add((Car)electricCarSuv.GetTesla());
            _cars.Add((Car)gasCarSedan.GetFord());
            _cars.Add((Car)electricCarSedan.GetHyundai());
            _cars.Add((Car)gasCarSuv.GetNissan());
        }

        public List<Car> GetCars() => _cars;
        public void AddCar(Car car) => _cars.Add(car);
    }
}
