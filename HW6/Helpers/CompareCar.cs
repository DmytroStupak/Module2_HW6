using HW6.Domain;

namespace HW6.Helpers
{
    public class CompareCar : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car? x, Car? y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Incorrect parameter value");
            }

            return (int)(x.Cost * 100) - (int)(y.Cost * 100);
        }
    }
}
