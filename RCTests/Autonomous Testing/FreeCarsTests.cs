using RCLibrary.Entities;
using RCLibrary;

namespace Autonomous_Testing
{
    [TestFixture] //ToDo #4.8 Тести класу FreeCars
    internal class FreeCarsTests
    {
        private FreeCars freeCars;
        private Auto car1, car2;
        private Contract contract;

        [SetUp]
        public void Setup()
        {
            freeCars = new FreeCars();
            FreeCars.AvailableCar.Clear();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();

            car1 = new Auto { Id = Guid.NewGuid(), Brand = "BMW", Model = "X5" };
            car2 = new Auto { Id = Guid.NewGuid(), Brand = "Audi", Model = "A4" };

            Auto.Autos.Add(car1);
            Auto.Autos.Add(car2);
        }

        [Test] //TCFC01
        public void TCFC01_AvailableCars_NoContracts_ReturnsAllCars()
        {
            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test] //TCFC02
        public void TCFC02_AvailableCars_WithContract_ReturnsOnlyAvailableCars()
        {
            contract = new Contract
            {
                Car = car1,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(3)
            };
            Contract.Contracts.Add(contract);

            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0], Is.EqualTo(car2));
        }

        [Test] //TCFC03
        public void TCFC03_AvailableCars_ContractEndsOnStartDate_ReturnsCar()
        {
            var contract1 = new Contract{ Car = car1, StartDate = DateTime.Today.AddDays(-3), EndDate = DateTime.Today };
            var contract2 = new Contract { Car = car2, StartDate = DateTime.Today.AddDays(-3), EndDate = DateTime.Today };

            Contract.Contracts.Add(contract1);
            Contract.Contracts.Add(contract2);

            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test] //TCFC04
        public void TCFC04_AvailableCars_PartialOverlap_ExcludesCar()
        {
            var contract = new Contract
            {
                Car = car1,
                StartDate = DateTime.Today.AddDays(-1),
                EndDate = DateTime.Today.AddDays(1) 
            };
            Contract.Contracts.Add(contract);

            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test] //TCFC05
        public void TCFC05_AvailableCars_ReturnsCorrectCarInstances()
        {
            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result, Does.Contain(car1));
            Assert.That(result, Does.Contain(car2));
        }

        [Test] //TCFC06
        public void TCFC06_AvailableCars_NoCars_ReturnsEmptyList()
        {
            Auto.Autos.Clear();
            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result, Is.Empty);
        }

        [Test] //TCFC07
        public void TCFC07_AvailableCars_PeriodFullyInsideContract_ExcludesCar()
        {
            var contract = new Contract
            {
                Car = car1,
                StartDate = DateTime.Today.AddDays(-1),
                EndDate = DateTime.Today.AddDays(2)
            };
            Contract.Contracts.Add(contract);

            var result = freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0], Is.EqualTo(car2));
        }

        [Test] //TCFC08
        public void TCFC08_AvailableCars_DoesNotModifyOriginalList()
        {
            var originalCars = new List<Auto>(Auto.Autos);
            freeCars.AvailableCars(DateTime.Today, DateTime.Today.AddDays(1));
            Assert.That(Auto.Autos, Is.EqualTo(originalCars));
        }
    }
}
