using RCLibrary.Entities;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture]
    public class AdminTests //ToDo #4.1 Тести класу Administrator +
    {
        private Administrator admin;
        private const string AdminsFilePath = "Admins.json";
        private const string ManagersFilePath = "Managers.json";

        [SetUp]
        public void Setup()
        {
            admin = new Administrator();

            // Очистити статичні списки
            Administrator.Administrators.Clear();
            Manager.Managers.Clear();

            // Очистити тестові файли
            CleanupTestFiles();
        }

        [TearDown]
        public void Cleanup()
        {
            CleanupTestFiles();
        }

        private void CleanupTestFiles()
        {
            string[] files = { AdminsFilePath, ManagersFilePath };
            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
        }

        [Test] // TCAd01
        public void TCAd01_AddManager_ValidManager_AddsToManagersList()
        {
            var manager = new Manager
            {
                Email = "manager@example.com",
                Password = "Password123"
            };

            bool result = admin.AddManager(manager);

            Assert.IsTrue(result);
            Assert.That(Manager.Managers.Count, Is.EqualTo(1));
            Assert.That(manager.TypeClass, Is.EqualTo("Менеджер"));
            Assert.That(Manager.Managers.First(), Is.EqualTo(manager));
        }

        [Test] // TCAd02
        public void TCAd02_AddManager_DuplicateEmail_ReturnsFalse()
        {
            var manager1 = new Manager { Email = "duplicate@example.com" };
            var manager2 = new Manager { Email = "duplicate@example.com" };

            admin.AddManager(manager1);
            bool result = admin.AddManager(manager2);

            Assert.IsFalse(result);
        }

        [Test] // TCAd03
        public void TCAd03_RemoveManager_ValidIndex_RemovesFromList()
        {
            var manager = new Manager();
            Manager.Managers.Add(manager);
            int index = Manager.Managers.IndexOf(manager);

            bool result = admin.RemoveManager(index);

            Assert.IsTrue(result);
            Assert.That(Manager.Managers.Count, Is.EqualTo(0));
        }

        [Test] // TCAd04
        public void TCAd03_RemoveManager_InvalidIndex_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => admin.RemoveManager(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => admin.RemoveManager(100));
        }

        [Test] // TCAd05
        public void TCAd05_AddAdmin_ValidAdmin_AddsToAdminsList()
        {
            var newAdmin = new Administrator
            {
                Email = "admin@example.com",
                Password = "Password123"
            };

            bool result = admin.AddAdmin(newAdmin);

            Assert.IsTrue(result);
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(1));
            Assert.That(newAdmin.TypeClass, Is.EqualTo("Адміністратор"));
            Assert.That(Administrator.Administrators.First(), Is.EqualTo(newAdmin));
        }

        [Test] // TCAd06
        public void TCAd06_AddAdmin_DuplicateEmail_ReturnsFalse()
        {
            var admin1 = new Administrator { Email = "duplicate@example.com" };
            var admin2 = new Administrator { Email = "duplicate@example.com" };

            admin.AddAdmin(admin1);
            bool result = admin.AddAdmin(admin2);

            Assert.IsFalse(result);
        }

        [Test] // TCAd07
        public void TCAd07_RemoveAdmin_ValidIndex_RemovesFromList()
        {
            var administrator = new Administrator();
            Administrator.Administrators.Add(administrator);
            int index = Administrator.Administrators.IndexOf(administrator);

            bool result = admin.RemoveAdmin(index);

            Assert.IsTrue(result);
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(0));
        }

        [Test] // TCAd08
        public void TCAd08_RemoveAdmin_InvalidIndex_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => admin.RemoveAdmin(999));
        }

        [Test] // TCAd09
        public void TCAd09_RemoveAdmin_EmptyList_ThrowsException()
        {
            Administrator.Administrators.Clear();
            Assert.Throws<ArgumentOutOfRangeException>(() => admin.RemoveAdmin(0));
        }

        [Test] // TCAd10
        public void TCAd10_InheritedManagerMethods_WorkCorrectly()
        {
            // Перевірка успадкованих методів від Manager
            var car = new Auto { Brand = "Test", Model = "Model" };
            bool addCarResult = admin.AddCar(car);

            Assert.IsTrue(addCarResult);
        }
        
        [Test] // TCAd11
        public void TCAd11_Serialize_WithAdmins_CreatesFile()
        {
            // Додати тестового адміністратора
            Administrator.Administrators.Add(new Administrator { Email = "test@admin.com" });

            bool result = admin.Serialize();

            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(AdminsFilePath));
            Assert.Greater(new FileInfo(AdminsFilePath).Length, 0);
        }
                  
        [Test] // TCAd12
        public void TCAd12_Deserialize_WithExistingFile_LoadsData()
        {
            // Підготувати тестовий файл
            var testAdmin = new Administrator
            {
                Email = "test@admin.com",
                LastName = "Іванов",
                FirstName = "Іван",
                PhoneNumber = "0882145291",
                Password = "testIvan1"
            };
            Administrator.Administrators.Add(testAdmin);
            admin.Serialize();
            Administrator.Administrators.Clear();

            bool result = admin.Deserialize();

            Assert.IsTrue(result);
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(1));
            Assert.That(Administrator.Administrators[0].Email, Is.EqualTo("test@admin.com"));
        }

        [Test] // TCAd13
        public void TCAd13_Deserialize_CorruptedFile_ReturnsFalseOrThrows()
        {
            File.WriteAllText(AdminsFilePath, "{invalid-json}");
            Assert.Throws<JsonException>(() => admin.Deserialize());
        }
        
        [Test] // TCAd14
        public void TCAd14_Deserialize_FileNotExists_CreatesDefaultAdmin()
        {
            Administrator.Administrators.Clear();

            bool result = admin.Deserialize();

            Assert.IsTrue(result);
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(1));
            Assert.That(Administrator.Administrators[0].Email, Is.EqualTo("root@gmail.com"));
        }
    }
}