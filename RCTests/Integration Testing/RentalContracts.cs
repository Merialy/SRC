using RCLibrary.Entities;
using RCLibrary;
using Contract = RCLibrary.Entities.Contract;

namespace Integration_Testing
{
    [TestFixture]
    internal class RentalContracts //ToDo #6.2.3 Збірка 3: Договори оренди
    {
        private Manager _manager;
        private Client _client;
        private Auto _car;

        [SetUp]
        public void Setup()
        {
            _manager = new Manager();
            _client = new Client { Email = "client@test.com" };
            _car = new Auto { DailyPrice = 1500 };

            Client.Clients.Clear();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();

            Client.Clients.Add(_client);
            Auto.Autos.Add(_car);
        }

        [Test] // Тест 3.1: Створення договору
        public void CreateRentalContract_Success()
        {
            var contract = new Contract
            {
                Car = _car,
                Renter = _client,
                Employee = _manager,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3)
            };

            bool result = _manager.AddContract(contract);

            Assert.IsTrue(result);
            Assert.Contains(contract, Contract.Contracts);
            Assert.That(contract.RentalPrice, Is.EqualTo(6000));
        }

        [Test] // Тест 3.2: Створення договору із порожнім автомобілем
        public void CreateContract_NoCar_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _manager.AddContract(new Contract { Renter = _client, Car = null }));
        }

        [Test] // Тест 3.3: Відсутність машин для оренди автомобілів
        public void CreateContract_ForRentedCar_Failure()
        {
            var firstContract = new Contract
            {
                Car = _car,
                Renter = _client,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(3)
            };
            _manager.AddContract(firstContract);

            FreeCars freeCars = new();
            var frCar = freeCars.AvailableCars(DateTime.Now.AddDays(2), DateTime.Now.AddDays(4));

            Assert.That(frCar, Is.Empty);
        }

        [Test]
        public void FullRentalCycle_Success()
        {
            // 1. Адміністратор створює менеджера
            var admin = new Administrator();
            var manager = new Manager
            {
                Email = "e2e_manager@test.com",
                Password = "ManagerPass123!"
            };
            admin.AddManager(manager);

            // 2. Менеджер додає автомобіль
            var car = new Auto
            {
                Brand = "EndToEnd",
                Model = "TestCar",
                DailyPrice = 3000
            };
            manager.AddCar(car);

            // 3. Клієнт реєструється
            var userSystem = new UserSystem();
            var client = new Client
            {
                Email = "e2e_client@test.com",
                Password = "ClientPass123!",
                FirstName = "Енд",
                LastName = "Туенд"
            };
            userSystem.Register(client);

            // 4. Менеджер створює договір оренди
            var contract = new Contract
            {
                Car = car,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7)
            };
            manager.AddContract(contract);

            // 5. Перевіряємо результати
            Assert.That(Contract.Contracts.Count, Is.EqualTo(1));
            Assert.That(contract.RentalPrice, Is.EqualTo(24000));
            Assert.IsFalse(new FreeCars().AvailableCars(DateTime.Now, DateTime.Now.AddDays(10)).Contains(car));
        }
    }
}
