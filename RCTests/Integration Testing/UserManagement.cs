using RCLibrary.Entities;
using RCLibrary;

namespace Integration_Testing
{
    [TestFixture]
    internal class UserManagement //ToDo #6.2.1 Збірка 1: Управління користувачами
    {
        private UserSystem _userSystem;
        private Administrator _admin;

        [SetUp]
        public void Setup()
        {
            _userSystem = new UserSystem();
            _admin = new Administrator();
            UserSystem.Users.Clear();
            Client.Clients.Clear();
            Manager.Managers.Clear();
            Administrator.Administrators.Clear();
        }

        [Test] // Тест 1.1: Успішна реєстрація клієнта
        public void UserRegistration_Client_Success()
        {
            var client = new Client
            {
                Email = "newclient@test.com",
                Password = "Password123!",
                FirstName = "Іван",
                LastName = "Петров",
                PhoneNumber = "0987654321",
                DriverLicense = "ABC-123456",
                BirthDate = new DateTime(1990, 1, 1)
            };

            bool result = _userSystem.Register(client);

            Assert.IsTrue(result);
            Assert.Contains(client, UserSystem.Users);
        }

        [Test] // Тест 1.2: Помилка реєстрації дублікату електронної пошти користувача
        public void UserRegistration_DuplicateEmail_Failure()
        {
            var client1 = new Client { Email = "duplicate@test.com", Password = "PassPass123" };
            var client2 = new Client { Email = "duplicate@test.com", Password = "PassPass456" };

            _userSystem.Register(client1);
            bool result = _userSystem.Register(client2);

            Assert.IsFalse(result);
        }
                
        [Test] // Тест 1.3: Реєстрація з некоректним email
        public void RegisterClient_InvalidEmail_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _userSystem.Register(new Client { Email = "invalid-email" }));
        }

        // Тест 1.4: Успішна автентифікація
        [Test]
        public void Authenticate_ValidCredentials_Success()
        {
            var client = new Client
            {
                Email = "auth@test.com",
                Password = "Auth123!"
            };
            _userSystem.Register(client);

            var result = _userSystem.Authenticate("auth@test.com", "Auth123!");

            Assert.IsTrue(result);
        }

        [Test]// Тест 1.5: Адмін додає менеджера
        public void AdminAddsManager_Success()
        {
            var manager = new Manager
            {
                Email = "newmanager@test.com",
                Password = "ManagerPass123!",
                FirstName = "Марина",
                LastName = "Іванова"
            };

            bool result = _admin.AddManager(manager);

            Assert.IsTrue(result);
            Assert.Contains(manager, Manager.Managers);
            Assert.That(manager.TypeClass, Is.EqualTo("Менеджер"));
        }
    }
}
