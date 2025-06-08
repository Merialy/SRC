using RCLibrary.Entities;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture] 
    internal class ClientTests //ToDo #4.3 Тести класу Client
    {
        private Client client;
        private const string TestFilePath = "Clients.json";

        [SetUp]
        public void Setup()
        {
            client = new Client();
            Client.Clients.Clear();

            CleanupTestFile();
        }

        [TearDown]
        public void Cleanup()
        {
            CleanupTestFile();
        }

        private void CleanupTestFile()
        {
            if (File.Exists(TestFilePath))
                File.Delete(TestFilePath);
        }

        [Test] // TCCl01
        public void TCCl01_DriverLicense_ValidFormat_SetsValue()
        {
            var expected = "SSS-857321";
            client.DriverLicense = expected;
            Assert.That(client.DriverLicense, Is.EqualTo(expected));
        }

        // TCCl02
        [TestCase("")]
        [TestCase("Иван5")]
        [TestCase("742-DASADQ")]
        [TestCase("ASF-DSGDGSDGDSG")]
        [TestCase("ABC-123")] // замало цифр
        [TestCase("ABCD-123456")] // забагато букв
        public void TCCl02_DriverLicense_InvalidFormats_ThrowsArgumentException(string license)
        {
            Assert.Throws<ArgumentException>(() => client.DriverLicense = null);
            Assert.Throws<ArgumentException>(() => client.DriverLicense = license);
        }

        // TCCl03
        [TestCase(17, ExpectedResult = false)]
        [TestCase(18, ExpectedResult = true)]
        [TestCase(20, ExpectedResult = true)]
        public bool TCCl03_BirthDate_AgeValidation_WorksCorrectly(int yearsAgo)
        {
            var date = DateTime.Now.AddYears(-yearsAgo);
            try
            {
                client.BirthDate = date;
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        [Test] // TCCl04
        public void TCCl04_RentCar_NotImplemented_ThrowsException()
        {
            var auto = new Auto();
            Assert.Throws<NotImplementedException>(() => client.RentCar(auto));
        }

        [Test] // TCCl05
        public void TCCl05_ReturnCar_NotImplemented_ThrowsException()
        {
            var auto = new Auto();
            Assert.Throws<NotImplementedException>(() => client.ReturnCar(auto));
        }

        [Test] // TCCl06
        public void TCCl06_Register_NewClient_AddsToClientsList()
        {
            var newClient = new Client { Email = "new@example.com", Password = "Password123" };
            bool result = client.Register(newClient);
            Assert.IsTrue(result);
            Assert.That(Client.Clients.Count, Is.EqualTo(1));
        }

        [Test] // TCCl07
        public void TCCl07_Register_DuplicateEmail_ReturnsFalse()
        {
            var client1 = new Client { Email = "duplicate@example.com" };
            var client2 = new Client { Email = "duplicate@example.com" };

            client.Register(client1);
            bool result = client.Register(client2);

            Assert.IsFalse(result);
        }

        [Test] // TCCl08
        public void TCCl08_Serialize_CreatesFile()
        {
            // Додати тестового клієнта до списку
            Client.Clients.Add(new Client { Email = "test@example.com" });

            bool action = client.Serialize();

            Assert.IsTrue(action);
            Assert.IsTrue(File.Exists(TestFilePath));
            Assert.Greater(new FileInfo(TestFilePath).Length, 0);
        }

        [Test] // TCCl09
        public void TCCl09_Deserialize_WithExistingFile_LoadsData()
        {
            // Підготувати тестовий файл
            var testClient = new Client
            {
                Email = "test@example.com",
                DriverLicense = "ABC-123456",
                LastName = "Іванов",
                FirstName = "Іван",
                PhoneNumber = "0882145291",
                Password = "testIvan1"
            };
            Client.Clients.Add(testClient);
            client.Serialize();
            Client.Clients.Clear();

            bool action = client.Deserialize();

            Assert.IsTrue(action);
            Assert.That(Client.Clients.Count, Is.EqualTo(1));
            Assert.That(Client.Clients[0].Email, Is.EqualTo("test@example.com"));
            Assert.That(Client.Clients[0].DriverLicense, Is.EqualTo("ABC-123456"));
        }

        [Test] // TCCl10
        public void TCCl10_Deserialize_CorruptedFile_ThrowsException()
        {
            File.WriteAllText(TestFilePath, "{invalid-json}");
            Assert.Throws<JsonException>(() => client.Deserialize());
        }

        [Test] // TCCl11
        public void TCCl11_Deserialize_WithEmptyFile_CreatesEmptyList()
        {
            // Створити порожній файл
            File.WriteAllText(TestFilePath, "");

            bool action = client.Deserialize();

            Assert.IsTrue(action);
            Assert.That(Client.Clients.Count, Is.EqualTo(0));
        }

        // TCCl12, TCCl13
        [TestCase("Петренко", "Олег", "-", "ABC-123456", ExpectedResult = "Петренко О.-. (ABC-123456)")]
        [TestCase("Іванов", "Іван", "Іванович", "ABC-123456", ExpectedResult = "Іванов І.І. (ABC-123456)")]
        public string TCCl12_TCCl13_ToString_ReturnsCorrectFormat(string lastName, string firstName, string middleName, string driverLicense)
        {
            client.LastName = lastName;
            client.FirstName = firstName;
            client.MiddleName = middleName;
            client.DriverLicense = driverLicense;

            return client.ToString();
        }
    }
}
