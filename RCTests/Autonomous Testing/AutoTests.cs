using RCLibrary.Entities;
using RCLibrary;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture]
    public class AutoTests //ToDo #4.2 Тест класу Auto 
    {
        private Auto auto;
        private const string TestFilePath = "Autos.json";

        [SetUp]
        public void Setup()
        {
            auto = new Auto();
            Auto.Autos.Clear();

            // Очистити тестовий файл перед кожним тестом
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TearDown]
        public void Cleanup()
        {
            // Очистити тестовий файл після кожного тесту
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [Test] // TCAu01
        public void TCAu01_Id_IsGeneratedAutomatically_NotEmpty()
        {
            var newAuto = new Auto();
            Assert.That(newAuto.Id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test] // TCAu02
        public void TCAu02_Id_IsUniqueForEachAuto()
        {
            var auto1 = new Auto();
            var auto2 = new Auto();
            Assert.That(auto1.Id, Is.Not.EqualTo(auto2.Id));
        }
                
        [Test] // TCAu03
        public void TCAu03_Brand_EmptyValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.Brand = "");
        }

        [Test] // TCAu04
        public void TCAu04_Brand_TooLong_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.Brand = "jaoqszxmflqlsakgw");
        }

        [TestCase("Audi")] 
        [TestCase("BMW")]
        [TestCase("Mercedes")] // TCAu05
        public void TCAu05_Brand_ValidValues_SetsValue(string brand)
        {
            auto.Brand = brand;
            Assert.That(auto.Brand, Is.EqualTo(brand));
        }

        [Test] // TCAu06
        public void TCAu06_Brand_NullValue_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => auto.Brand = null);
        }

        [Test] // TCAu07
        public void TCAu07_Model_EmptyValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.Model = "");
        }

        [Test] // TCAu08
        public void TCAu08_Model_TooLong_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.Model = "jaoqszxmflqlsakgw");
        }

        [TestCase("Q7")]
        [TestCase("X5")]
        [TestCase("Camry")] // TCAu09
        public void TCAu09_Model_ValidValues_SetsValue(string model)
        {
            auto.Model = model;
            Assert.That(auto.Model, Is.EqualTo(model));
        }

        [Test] // TCAu10
        public void TCAu10_Model_NullValue_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => auto.Model = null);
        }

        [Test] // TCAu11
        public void TCAu11_Aclass_CanBeNull()
        {
            auto.Aclass = null;
            Assert.IsNull(auto.Aclass);
        }

        [Test] // TCAu12
        public void TCAu12_Aclass_CanBeSet()
        {
            auto.Aclass = classAuto.Середній;
            Assert.That(auto.Aclass, Is.EqualTo(classAuto.Середній));
        }

        [Test] // TCAu13
        public void TCAu13_Atype_CanBeNull()
        {
            auto.Atype = null;
            Assert.IsNull(auto.Atype);
        }

        [Test] // TCAu14
        public void TCAu14_Atype_CanBeSet()
        {
            auto.Atype = gearboxType.Автомат;
            Assert.That(auto.Atype, Is.EqualTo(gearboxType.Автомат));
        }

        [Test] // TCAu15
        public void TCAu15_Acolor_CanBeNull()
        {
            auto.Acolor = null;
            Assert.IsNull(auto.Acolor);
        }

        [Test] // TCAu16
        public void TCAu16_Acolor_CanBeSet()
        {
            auto.Acolor = colorAuto.Червоний;
            Assert.That(auto.Acolor, Is.EqualTo(colorAuto.Червоний));
        }

        [Test] // TCAu17
        public void TCAu17_DailyPrice_TooLow_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.DailyPrice = 0);
            Assert.Throws<ArgumentException>(() => auto.DailyPrice = 799);
        }

        [Test] // TCAu18
        public void TCAu18_DailyPrice_TooHigh_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => auto.DailyPrice = 10001);
        }

        [TestCase(800)]
        [TestCase(1000)]
        [TestCase(5000)]
        [TestCase(9999)] // TCAu19
        public void TCAu19_DailyPrice_ValidValues_SetsValue(int price)
        {
            auto.DailyPrice = price;
            Assert.That(auto.DailyPrice, Is.EqualTo(price));
        }

        [Test] // TCAu20
        public void TCAu20_DailyPrice_BoundaryValues_SetsValue()
        {
            auto.DailyPrice = 800;
            Assert.That(auto.DailyPrice, Is.EqualTo(800));

            auto.DailyPrice = 10000;
            Assert.That(auto.DailyPrice, Is.EqualTo(10000));
        }

        [Test] // TCAu21
        public void TCAu21_DailyPrice_MinAllowedValue_SetsValue()
        {
            auto.DailyPrice = 800;
            Assert.That(auto.DailyPrice, Is.EqualTo(800));
        }

        [Test] // TCAu22
        public void TCAu22_DailyPrice_MaxAllowedValue_SetsValue()
        {
            auto.DailyPrice = 10000;
            Assert.That(auto.DailyPrice, Is.EqualTo(10000));
        }

        [Test] // TCAu23
        public void TCAu23_Serialize_CreatesFile()
        {
            // Додати тестове авто до списку
            Auto.Autos.Add(new Auto { Brand = "Test", Model = "Model" });

            bool action = auto.Serialize();

            Assert.IsTrue(action);
            Assert.IsTrue(File.Exists(TestFilePath));
            Assert.Greater(new FileInfo(TestFilePath).Length, 0);
        }

        [Test] // TCAu24
        public void TCAu24_Deserialize_WithExistingFile_LoadsData()
        {
            // Підготувати тестовий файл
            var testAuto = new Auto { Brand = "Test", Model = "Model", DailyPrice = 1000 };
            Auto.Autos.Add(testAuto);
            auto.Serialize();
            Auto.Autos.Clear();

            bool action = auto.Deserialize();

            Assert.IsTrue(action);
            Assert.That(Auto.Autos.Count, Is.EqualTo(1));
            Assert.That(Auto.Autos[0].Brand, Is.EqualTo("Test"));
            Assert.That(Auto.Autos[0].Model, Is.EqualTo("Model"));
            Assert.That(Auto.Autos[0].DailyPrice, Is.EqualTo(1000));
        }
        
        [Test] // TCAu25
        public void TCAu25_Deserialize_EmptyFile_ReturnsTrueButNoData()
        {
            File.WriteAllText(TestFilePath, "");
            bool result = auto.Deserialize();
            Assert.IsTrue(result);
            Assert.That(Auto.Autos.Count, Is.EqualTo(0));
        }

        [Test] // TCAu26
        public void TCAu26_Deserialize_CorruptedFile_ThrowsException()
        {
            File.WriteAllText(TestFilePath, "{invalid-json}");
            Assert.Throws<JsonException>(() => auto.Deserialize());
        }

        [Test] // TCAu27
        public void TCAu27_ToString_ReturnsCorrectFormat()
        {
            auto.Brand = "Audi";
            auto.Model = "Q7";
            auto.Aclass = classAuto.Бізнес;
            auto.Atype = gearboxType.Автомат;
            auto.Acolor = colorAuto.Чорний;

            Assert.That(auto.ToString(), Is.EqualTo("Audi Q7 (Бізнес, Автомат, Чорний)"));
        }
    }
}
