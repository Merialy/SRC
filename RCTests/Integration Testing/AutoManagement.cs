using RCLibrary.Entities;
using RCLibrary;

namespace Integration_Testing
{
    [TestFixture]
    internal class AutoManagement //ToDo #6.2.2 Збірка 2: Управління автомобілями
    {
        private Manager _manager;
        private FreeCars _freeCars;

        [SetUp]
        public void Setup()
        {
            _manager = new Manager();
            _freeCars = new FreeCars();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();
        }

        [Test] // Тест 2.1: Додавання автомобіля
        public void ManagerAddsCar_Success()
        {
            var car = new Auto
            {
                Brand = "Toyota",
                Model = "Camry",
                DailyPrice = 1500,
                Aclass = classAuto.Бізнес,
                Atype = gearboxType.Автомат,
                Acolor = colorAuto.Чорний
            };

            bool result = _manager.AddCar(car);

            Assert.IsTrue(result);
            Assert.Contains(car, Auto.Autos);
        }

        // Тест 2.2: Додавання автомобіля з неприпустимою ціною
        [Test]
        public void ManagerAddsCar_InvalidPrice_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _manager.AddCar(new Auto { DailyPrice = 500 }));
        }

        // Тест 2.3: Перевірка доступних автомобілів
        [Test]
        public void GetAvailableCars_NoContracts_ReturnsAllCars()
        {
            var car1 = new Auto { Brand = "Audi" };
            var car2 = new Auto { Brand = "Mercedes" };
            Auto.Autos.AddRange(new[] { car1, car2 });

            var availableCars = _freeCars.AvailableCars(DateTime.Now, DateTime.Now.AddDays(1));

            Assert.That(availableCars.Count, Is.EqualTo(2));
        }

        [Test] // Тест 2.4: Перевірка за наявності активного договору
        public void CheckAvailableCars_WithActiveContract_ReturnsCorrectList()
        {
            var availableCar = new Auto { Brand = "Available", Model = "Car" };
            var rentedCar = new Auto { Brand = "Rented", Model = "Car" };

            Auto.Autos.AddRange(new[] { availableCar, rentedCar });

            Contract.Contracts.Add(new Contract
            {
                Car = rentedCar,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(3)
            });

            var result = _freeCars.AvailableCars(DateTime.Now, DateTime.Now.AddDays(5));

            Assert.Contains(availableCar, result);
            Assert.IsFalse(result.Contains(rentedCar));
            Assert.That(result.Count, Is.EqualTo(1));
        }
    }
}
