using RCLibrary.Entities;

namespace RCLibrary
{
    //ToDo #2.6 Клас вільних автомобілів +
    public class FreeCars : Auto
    {
        private static List<Auto> availableCars = new();
        public static List<Auto> AvailableCar {  get { return availableCars; } }

        public List<Auto> AvailableCars(DateTime startDate, DateTime endDate)
        {
            availableCars.Clear();
            foreach (Auto? car in Auto.Autos)
            {
                // Перевіряємо, що у автомобіля немає договорів на вказану дату
                if (!Contract.Contracts.Exists(c => c.Car.Id == car.Id && startDate <= c.EndDate && endDate >= c.StartDate))
                {
                    availableCars.Add(car);
                }
            }
            return availableCars;
        }
    }
}
