using RCLibrary.Entities;

namespace Acceptance_Testing
{
    [TestFixture]
    internal class AutoValidationTests
    {
        private Auto car;

        [SetUp]
        public void Setup()
        {
            car = new Auto();
        }

        // FR06: Бренд не довше 15 символів
        [Test]
        public void FR06_Brand_ValidLength_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => car.Brand = "Toyota");
        }

        // FR06: Бренд довше 15 символів
        [Test]
        public void FR06_Brand_TooLong_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => car.Brand = "VeryLongBrandName123");
        }

        // FR06: Ціна оренди в межах 800–10000 грн
        [Test]
        public void FR06_DailyPrice_ValidRange_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => car.DailyPrice = 1000);
        }

        // FR06: Ціна менше 800 грн
        [Test]
        public void FR06_DailyPrice_BelowMin_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => car.DailyPrice = 700);
        }
    }
}
