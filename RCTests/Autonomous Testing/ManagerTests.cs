using RCLibrary.Entities;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture]
    internal class ManagerTests //ToDo #4.4 Тест класу Manager
    {
        private Manager manager;
        private const string ManagersFilePath = "Managers.json";
        private const string AutosFilePath = "Autos.json";
        private const string ClientsFilePath = "Clients.json";
        private const string ContractsFilePath = "Contracts.json";

        [SetUp]
        public void Setup()
        {
            manager = new Manager();
                        
            ClearStaticCollections(); // Очистити статичні списки
            CleanupTestFiles(); // Очистити тестові файли
        }

        [TearDown]
        public void Cleanup()
        {
            CleanupTestFiles();
        }

        private void ClearStaticCollections()
        {
            Manager.Managers.Clear();
            Auto.Autos.Clear();
            Client.Clients.Clear();
            Contract.Contracts.Clear();
        }

        private void CleanupTestFiles()
        {
            string[] files = { ManagersFilePath, AutosFilePath, ClientsFilePath, ContractsFilePath };
            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
        }

        [Test] //TCM01
        public void TCM01_AddCar_ValidCar_AddsToAutosList()
        {
            var car = new Auto { Brand = "Audi", Model = "Q7", DailyPrice = 4000 };

            bool result = manager.AddCar(car);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(result);
                Assert.That(Auto.Autos, Has.Count.EqualTo(1).And.Contain(car));
            });
        }

        [Test] //TCM02
        public void TCM02_AddCar_NullCar_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => manager.AddCar(null));
        }

        [Test] //TCM03
        public void TCM03_AddClient_ValidClient_AddsToClientsList()
        {
            var client = new Client
            {
                Email = "test@example.com",
                Password = "Password123",
                DriverLicense = "ABC-123456",
                BirthDate = DateTime.Now.AddYears(-20)
            };

            bool result = manager.AddClient(client);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(result);
                Assert.That(Client.Clients, Has.Count.EqualTo(1).And.Contain(client));
                Assert.That(client.TypeClass, Is.EqualTo("Клієнт"));
            });
        }

        [Test] //TCM04
        public void TCM04_AddClient_DuplicateEmail_ReturnsFalse()
        {
            var client1 = new Client { Email = "duplicate@example.com" };
            var client2 = new Client { Email = "duplicate@example.com" };

            manager.AddClient(client1);
            bool result = manager.AddClient(client2);

            Assert.IsFalse(result);
        }

        [Test] //TCM05
        public void TCM05_AddContract_ValidContract_AddsToContractsList()
        {
            var contract = new Contract
            {
                Car = new Auto(),
                Renter = new Client(),
                Employee = new Manager(),
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(3)
            };

            bool result = manager.AddContract(contract);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(result);
                Assert.That(Contract.Contracts, Has.Count.EqualTo(1));
                Assert.That(contract.Id, Is.EqualTo(1));
            });
        }

        [Test] //TCM06
        public void TCM06_AddContract_WithInvalidCar_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var contract = new Contract { Car = null };
            });
        }

        [Test] //TCM07
        public void TCM07_AddContract_NullContract_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => manager.AddContract(null));
        }

        [Test] //TCM08
        public void TCM08_AddContract_WithInvalidClient_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var contract = new Contract { Renter = null };
            });
        }

        [Test] //TCM09
        public void TCM09_AddContract_AutoIncrementsId()
        {
            manager.AddContract(new Contract());
            manager.AddContract(new Contract());

            Assert.That(Contract.Contracts.Select(c => c.Id), Is.EqualTo(new[] { 1, 2 }));
        }

        [Test] //TCM10
        public void TCM10_RemoveClient_InvalidIndex_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => manager.RemoveClient(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => manager.RemoveClient(100));
        }
        
        [Test] //TCM11
        public void TCM11_RemoveClient_ValidIndex_RemovesFromList()
        {
            var client = new Client();
            Client.Clients.Add(client);
            int index = Client.Clients.IndexOf(client);

            bool result = manager.RemoveClient(index);

            Assert.IsTrue(result);
            Assert.That(Client.Clients.Count, Is.EqualTo(0));
        }
        
        [Test] //TCM12
        public void TCM12_RemoveContract_ValidIndex_RemovesFromList()
        {
            var contract = new Contract();
            Contract.Contracts.Add(contract);
            int index = Contract.Contracts.IndexOf(contract);

            bool result = manager.RemoveContract(index);

            Assert.IsTrue(result);
            Assert.That(Contract.Contracts.Count, Is.EqualTo(0));
        }

        [Test] //TCM13
        public void TCM13_RemoveCar_ValidIndex_RemovesFromList()
        {
            var car = new Auto();
            Auto.Autos.Add(car);
            int index = Auto.Autos.IndexOf(car);

            bool result = manager.RemoveCar(index);

            Assert.IsTrue(result);
            Assert.That(Auto.Autos.Count, Is.EqualTo(0));
        }

        [TestCase(-1)]
        [TestCase(100)] //TCM14
        public void TCM14_RemoveCar_InvalidIndex_ThrowsException(int index)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => manager.RemoveCar(index));
        }

        [Test] //TCM15
        public void TCM15_Serialize_WithManagers_CreatesFile()
        {
            // Додати тестового менеджера
            Manager.Managers.Add(new Manager { Email = "test@manager.com" });

            bool result = manager.Serialize();

            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(ManagersFilePath));
            Assert.Greater(new FileInfo(ManagersFilePath).Length, 0);
        }

        [Test] //TCM16
        public void TCM16_Deserialize_WithExistingFile_LoadsData()
        {
            // Підготувати тестовий файл
            var testManager = new Manager
            {
                Email = "test@manager.com",
                LastName = "Іванов",
                FirstName = "Іван",
                PhoneNumber = "0882145291",
                Password = "testIvan1"
            };

            Manager.Managers.Add(testManager);
            manager.Serialize();
            Manager.Managers.Clear();

            bool result = manager.Deserialize();

            Assert.IsTrue(result);
            Assert.That(Manager.Managers.Count, Is.EqualTo(1));
            Assert.That(Manager.Managers[0].Email, Is.EqualTo("test@manager.com"));
        }

        [Test] //TCM17
        public void TCM17_Deserialize_EmptyFile_ReturnsTrueButNoData()
        {
            File.WriteAllText(ManagersFilePath, "");
            bool result = manager.Deserialize();
            Assert.IsTrue(result);
            Assert.That(Manager.Managers.Count, Is.EqualTo(0));
        }

        [Test] //TCM18
        public void TCM18_Deserialize_CorruptedFile_ThrowsException()
        {
            File.WriteAllText(ManagersFilePath, "{invalid-json}");
            Assert.Throws<JsonException>(() => manager.Deserialize());
        }

        [Test] //TCM19
        public void TCM19_ToString_ReturnsCorrectFormat()
        {
            manager.LastName = "Петренко";
            manager.FirstName = "Іван";
            Assert.That(manager.ToString(), Is.EqualTo("Петренко І.-."));
        }
    }
}
