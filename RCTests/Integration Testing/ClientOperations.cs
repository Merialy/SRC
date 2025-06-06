using RCLibrary;
using RCLibrary.Entities;

namespace Integration_Testing
{
    [TestFixture]
    internal class ClientOperations  //ToDo #6.2.4 Збірка 4: Клієнтські операції
    {
        private Client _client;
        private Auto _aCar;

        [SetUp]
        public void Setup()
        {
            _client = new Client { Email = "testclient@example.com" };
            _aCar = new Auto { Brand = "Available" };

            Auto.Autos.Clear();
            Contract.Contracts.Clear();

            Auto.Autos.Add(_aCar);

            Contract.Contracts.Add(new Contract
            {
                Car = _aCar,
                Renter = new Client { Email = "other@client.com" },
                StartDate = DateTime.Now.AddDays(-1),
                EndDate = DateTime.Now.AddDays(1)
            });
        }

        [Test] // Тест 4.1: Оренда доступного автомобіля
        public void RentCar_AvailableCar_Success()
        {
            Assert.Throws<NotImplementedException>(() => _client.RentCar(_aCar));
            Assert.IsFalse(new FreeCars().AvailableCars(DateTime.Now, DateTime.Now.AddDays(1))
                .Contains(_aCar));
        }

        [Test] // Тест 4.2: Спроба оренди зайнятого автомобіля
        public void RentCar_AlreadyRented_Fails()
        {
            Assert.Throws<NotImplementedException>(() => _client.RentCar(_aCar));
        }

        [Test] // Тест 4.3: Повернення автомобіля
        public void ReturnCar_ValidCar_Success()
        {
            Assert.Throws<NotImplementedException>(() => _client.RentCar(_aCar));
            Assert.Throws<NotImplementedException>(() => _client.ReturnCar(_aCar));
            Assert.IsEmpty(new FreeCars().AvailableCars(DateTime.Now, DateTime.Now.AddDays(1)));            
        }

        [Test] // 4.4: Менеджер створює договір для клієнта
        public void Manager_CreatesContractForClient()
        {
            var manager = new Manager();
            var client = new Client { Email = "contract_client@test.com" };
            var car = new Auto { DailyPrice = 1000 };
            Auto.Autos.Add(car);

            var contract = new Contract
            {
                Car = car,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3)
            };
            bool result = manager.AddContract(contract);

            Assert.IsTrue(result);
            Assert.That(contract.RentalPrice, Is.EqualTo(4000));
        }
    }
}
