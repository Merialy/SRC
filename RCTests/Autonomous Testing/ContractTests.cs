using RCLibrary.Entities;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture] //ToDo #4.5 Тести класу Contract
    internal class ContractTests
    {
        private Contract contract;
        private const string TestFilePath = "Contracts.json";

        [SetUp]
        public void Setup()
        {
            contract = new Contract();
            Contract.Contracts.Clear();
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

        [Test] //TCCo01
        public void TCCo01_Renter_ValidClient_SetsValue()
        {
            var renter = new Client();
            contract.Renter = renter;
            Assert.That(contract.Renter, Is.EqualTo(renter));
        }

        [Test] //TCCo02
        public void TCCo02_Renter_NullValue_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => contract.Renter = null);
        }

        [Test] //TCCo03
        public void TCCo03_Car_ValidAuto_SetsValue()
        {
            var car = new Auto();
            contract.Car = car;
            Assert.That(contract.Car, Is.EqualTo(car));
        }

        [Test] //TCCo04
        public void TCCo04_Car_NullValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => contract.Car = null);
        }

        [Test] //TCCo05
        public void TCCo05_Employee_ValidManager_SetsValue()
        {
            var manager = new Manager();
            contract.Employee = manager;
            Assert.That(contract.Employee, Is.EqualTo(manager));
        }

        [Test] //TCCo06
        public void TCCo06_Employee_NullValue_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => contract.Employee = null);
        }

        [Test] //TCCo07
        public void TCCo07_StartDate_SetsAndGetsCorrectValue()
        {
            var expectedDate = DateTime.Today;
            contract.StartDate = expectedDate;
            Assert.That(contract.StartDate, Is.EqualTo(expectedDate));
        }

        [Test] //TCCo08
        public void TCCo08_EndDate_SetsAndGetsCorrectValue()
        {
            var expectedDate = DateTime.Today.AddDays(7);
            contract.EndDate = expectedDate;
            Assert.That(contract.EndDate, Is.EqualTo(expectedDate));
        }

        [Test] //TCCo09
        public void TCCo09_RentalPrice_CalculatesCorrectly()
        {
            // Arrange
            var car = new Auto { DailyPrice = 1000 };
            contract.Car = car;
            contract.StartDate = DateTime.Today;
            contract.EndDate = DateTime.Today.AddDays(5);

            // Act
            var price = contract.RentalPrice;

            // Assert
            Assert.That(price, Is.EqualTo(6000));
        }

        [Test] //TCCo10
        public void TCCo10_RentalPrice_EndDateBeforeStartDate_ReturnsZero()
        {
            // Arrange
            var car = new Auto { DailyPrice = 1000 };
            contract.Car = car;
            contract.StartDate = DateTime.Today;
            contract.EndDate = DateTime.Today.AddDays(-1);

            // Act
            var price = contract.RentalPrice;

            // Assert
            Assert.That(price, Is.EqualTo(0));
        }

        [Test] //TCCo11
        public void TCCo11_Serialize_CreatesFile()
        {
            // Arrange
            Contract.Contracts.Add(new Contract { Id = 1 });

            // Act
            bool result = contract.Serialize();

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(TestFilePath));
            Assert.Greater(new FileInfo(TestFilePath).Length, 0);
        }

        [Test] //TCCo12
        public void TCCo12_Serialize_WithRealData_CreatesValidJson()
        {
            var testContract = new Contract
            {
                Id = 1,
                Car = new Auto { Brand = "Test", Model = "Model" },
                Renter = new Client { LastName = "Test" },
                Employee = new Manager { LastName = "Manager" },
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(1)
            };
            Contract.Contracts.Add(testContract);

            bool result = contract.Serialize();
            Assert.IsTrue(result);

            string fileContent = File.ReadAllText(TestFilePath);
            Assert.That(fileContent, Does.Contain("\"Brand\":\"Test\""));
        }

        [Test] //TCCo13
        public void TCCo13_Deserialize_WithEmptyFile_CreatesEmptyList()
        {
            // Arrange
            File.WriteAllText(TestFilePath, "");

            // Act
            bool result = contract.Deserialize();

            // Assert
            Assert.IsTrue(result);
            Assert.That(Contract.Contracts.Count, Is.EqualTo(0));
        }

        [Test] //TCCo14
        public void TCCo14_Deserialize_CorruptedFile_ThrowsException()
        {
            File.WriteAllText(TestFilePath, "{invalid-json}");
            Assert.Throws<JsonException>(() => contract.Deserialize());
        }
    }
}
