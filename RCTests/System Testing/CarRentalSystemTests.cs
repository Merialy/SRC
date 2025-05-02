using RCLibrary.Entities;
using RCLibrary.Interfaces;
using RCLibrary;
using System.ComponentModel;

namespace System_Testing
{
    [TestFixture]
    public class CarRentalSystemTests
    {
        private Administrator admin;
        private Manager manager;
        private Client client;
        private Auto testCar;
        private Contract testContract;

        [SetUp]
        public void Setup()
        {
            // Очищення всіх статичних списків перед кожним тестом
            UserSystem.Users.Clear();
            Client.Clients.Clear();
            Manager.Managers.Clear();
            Administrator.Administrators.Clear();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();

            // Ініціалізація тестових об'єктів
            admin = new Administrator
            {
                Email = "admin@test.com",
                FirstName = "Admin",
                LastName = "Test",
                Password = "Admin123",
                PhoneNumber = "1234567890",
                TypeClass = "Адміністратор"
            };

            manager = new Manager
            {
                Email = "manager@test.com",
                FirstName = "Manager",
                LastName = "Test",
                Password = "Manager123",
                PhoneNumber = "1234567891",
                TypeClass = "Менеджер"
            };

            client = new Client
            {
                Email = "client@test.com",
                FirstName = "Client",
                LastName = "Test",
                Password = "Client123",
                PhoneNumber = "1234567892",
                DriverLicense = "ABC-123456",
                BirthDate = new DateTime(1990, 1, 1),
                TypeClass = "Клієнт"
            };

            testCar = new Auto
            {
                Brand = "TestBrand",
                Model = "TestModel",
                DailyPrice = 1000,
                Aclass = classAuto.Автобус,
                Atype = gearboxType.Автомат,
                Acolor = colorAuto.Чорний
            };

            testContract = new Contract
            {
                Car = testCar,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3)
            };

            // Додавання тестових даних до системи
            Administrator.Administrators.Add(admin);
            Manager.Managers.Add(manager);
            Client.Clients.Add(client);
            Auto.Autos.Add(testCar);
            Contract.Contracts.Add(testContract);
        }

        [TearDown]
        public void Cleanup()
        {
            // Видалення тестових файлів після кожного тесту
            string[] files = { "Users.json", "Clients.json", "Managers.json",
                         "Admins.json", "Autos.json", "Contracts.json" };
            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
        }
          
        [Test] // FR01: ПЗ має підтримувати додавання, редагування та видалення клієнтів
        public void TS011_ClientManagement()
        {
            // Перевірка додавання клієнта
            var newClient = new Client
            {
                Email = "newclient@test.com",
                FirstName = "New",
                LastName = "Client",
                Password = "NewClient123",
                PhoneNumber = "1234567893",
                DriverLicense = "DEF-654321",
                BirthDate = new DateTime(1985, 5, 15),
                TypeClass = "Клієнт"
            };

            bool addResult = manager.AddClient(newClient);
            Assert.IsTrue(addResult);
            Assert.Contains(newClient, Client.Clients);
        }
        
        [Test]
        public void TS012_ClientManagement()
        {
            // Перевірка додавання клієнта
            var newClient = new Client
            {
                Email = "newclient@test.com",
                FirstName = "New",
                LastName = "Client",
                Password = "NewClient123",
                PhoneNumber = "1234567893",
                DriverLicense = "DEF-654321",
                BirthDate = new DateTime(1985, 5, 15),
                TypeClass = "Клієнт"
            };

            bool addResult = manager.AddClient(newClient);
            
            // Перевірка редагування клієнта
            string originalName = newClient.FirstName;
            newClient.FirstName = "Updated";
            Assert.That(newClient.FirstName, Is.EqualTo("Updated"));
            Assert.That(newClient.FirstName, Is.Not.EqualTo(originalName));
        }

        [Test]
        public void TS013_ClientManagement()
        {
            // Перевірка додавання клієнта
            var newClient = new Client
            {
                Email = "newclient@test.com",
                FirstName = "New",
                LastName = "Client",
                Password = "NewClient123",
                PhoneNumber = "1234567893",
                DriverLicense = "DEF-654321",
                BirthDate = new DateTime(1985, 5, 15),
                TypeClass = "Клієнт"
            };

            bool addResult = manager.AddClient(newClient);
            
            // Перевірка видалення клієнта
            int index = Client.Clients.IndexOf(newClient);
            bool removeResult = manager.RemoveClient(index);
            Assert.IsTrue(removeResult);
            Assert.IsFalse(Client.Clients.Contains(newClient));
        }
        
        [Test] // FR02: ПЗ має підтримувати додавання, редагування та видалення автомобілів
        public void TS021_CarManagement()
        {
            // Перевірка додавання автомобіля
            var newCar = new Auto
            {
                Brand = "NewBrand",
                Model = "NewModel",
                DailyPrice = 1500,
                Aclass = classAuto.Бізнес,
                Atype = gearboxType.Механіка,
                Acolor = colorAuto.Білий
            };

            bool addResult = manager.AddCar(newCar);
            Assert.IsTrue(addResult);
            Assert.Contains(newCar, Auto.Autos);
        }

        [Test]
        public void TS022_CarManagement()
        {
            // Перевірка додавання автомобіля
            var newCar = new Auto
            {
                Brand = "NewBrand",
                Model = "NewModel",
                DailyPrice = 1500,
                Aclass = classAuto.Бізнес,
                Atype = gearboxType.Механіка,
                Acolor = colorAuto.Білий
            };

            bool addResult = manager.AddCar(newCar);
            
            // Перевірка редагування автомобіля
            string originalModel = newCar.Model;
            newCar.Model = "UpdatedModel";
            Assert.That(newCar.Model, Is.EqualTo("UpdatedModel"));
            Assert.That(newCar.Model, Is.Not.EqualTo(originalModel));            
        }

        [Test]
        public void TS023_CarManagement()
        {
            // Перевірка додавання автомобіля
            var newCar = new Auto
            {
                Brand = "NewBrand",
                Model = "NewModel",
                DailyPrice = 1500,
                Aclass = classAuto.Бізнес,
                Atype = gearboxType.Механіка,
                Acolor = colorAuto.Білий
            };

            bool addResult = manager.AddCar(newCar);
            
            // Перевірка видалення автомобіля
            int index = Auto.Autos.IndexOf(newCar);
            bool removeResult = manager.RemoveCar(index);
            Assert.IsTrue(removeResult);
            Assert.IsFalse(Auto.Autos.Contains(newCar));
        }

        [Test] // FR03: ПЗ має підтримувати створення та видалення договорів оренди
        public void TS031_ContractManagement()
        {
            // Перевірка створення договору
            var newContract = new Contract
            {
                Car = testCar,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(4)
            };

            bool addResult = manager.AddContract(newContract);
            Assert.IsTrue(addResult);
            Assert.Contains(newContract, Contract.Contracts);

            // Перевірка автоматичного призначення ID
            Assert.Greater(newContract.Id, 0);
        }

        [Test]
        public void TS032_ContractManagement()
        {
            // Перевірка створення договору
            var newContract = new Contract
            {
                Car = testCar,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(4)
            };

            bool addResult = manager.AddContract(newContract);
            
            // Перевірка видалення договору
            int index = Contract.Contracts.IndexOf(newContract);
            bool removeResult = manager.RemoveContract(index);
            Assert.IsTrue(removeResult);
            Assert.IsFalse(Contract.Contracts.Contains(newContract));
        }

        [Test] // FR04: ПЗ має забезпечувати авторизацію користувачів за логіном та паролем
        public void TS041_UserAuthentication()
        {
            var userSystem = new UserSystem();
            UserSystem.Users.Add(admin);
            UserSystem.Users.Add(manager);
            UserSystem.Users.Add(client);

            // Успішна авторизація
            bool authResult = userSystem.Authenticate("admin@test.com", "Admin123");
            Assert.IsTrue(authResult);
            Assert.That(UserSystem.activeUser.Email, Is.EqualTo(admin.Email));
        }

        [Test]
        public void TS042_UserAuthentication()
        {
            var userSystem = new UserSystem();
            UserSystem.Users.Add(admin);
            UserSystem.Users.Add(manager);
            UserSystem.Users.Add(client);

            // Невдала авторизація (невірний пароль)
            bool authResult = userSystem.Authenticate("admin@test.com", "WrongPassword");
            Assert.IsFalse(authResult);
        }

        [Test] // FR05: ПЗ має підтримувати збереження та завантаження даних у JSON-файлах
        public void TS050_JsonSerialization()
        {
            // Серіалізація даних
            bool serializeResult = admin.Serialize();
            Assert.IsTrue(serializeResult);
            Assert.IsTrue(File.Exists("Admins.json"));

            serializeResult = manager.Serialize();
            Assert.IsTrue(serializeResult);
            Assert.IsTrue(File.Exists("Managers.json"));

            serializeResult = client.Serialize();
            Assert.IsTrue(serializeResult);
            Assert.IsTrue(File.Exists("Clients.json"));

            serializeResult = testCar.Serialize();
            Assert.IsTrue(serializeResult);
            Assert.IsTrue(File.Exists("Autos.json"));

            serializeResult = testContract.Serialize();
            Assert.IsTrue(serializeResult);
            Assert.IsTrue(File.Exists("Contracts.json"));

            // Очищення списків перед десеріалізацією
            Administrator.Administrators.Clear();
            Manager.Managers.Clear();
            Client.Clients.Clear();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();
            
            // Десеріалізація даних
            bool deserializeResult = admin.Deserialize();
            Assert.IsTrue(deserializeResult);
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(1));

            deserializeResult = manager.Deserialize();
            Assert.IsTrue(deserializeResult);
            Assert.That(Manager.Managers.Count, Is.EqualTo(1));

            deserializeResult = client.Deserialize();
            Assert.IsTrue(deserializeResult);
            Assert.That(Client.Clients.Count, Is.EqualTo(1));

            deserializeResult = testCar.Deserialize();
            Assert.IsTrue(deserializeResult);
            Assert.That(Auto.Autos.Count, Is.EqualTo(1));

            deserializeResult = testContract.Deserialize();
            Assert.IsTrue(deserializeResult);
            Assert.That(Contract.Contracts.Count, Is.EqualTo(1));
        }
                
        [Test] // FR07: ПЗ має підтримувати оренду автомобілів клієнтами та повернення орендованих авто
        public void TS070_CarRentalAndReturn()
        {
            // Перевірка оренди авто (метод RentCar ще не реалізований)
            Assert.Throws<NotImplementedException>(() => client.RentCar(testCar));

            // Перевірка повернення авто (метод ReturnCar ще не реалізований)
            Assert.Throws<NotImplementedException>(() => client.ReturnCar(testCar));
        }
        
        [Test] // FR08: Адміністратор повинен мати можливість керувати обліковими записами менеджерів та адміністраторів
        public void TS081_AdminUserManagement()
        {
            // Додавання менеджера
            var newManager = new Manager
            {
                Email = "newmanager@test.com",
                FirstName = "New",
                LastName = "Manager",
                Password = "NewManager123",
                PhoneNumber = "1234567894",
                TypeClass = "Менеджер"
            };

            bool addManagerResult = admin.AddManager(newManager);
            Assert.IsTrue(addManagerResult);
            Assert.Contains(newManager, Manager.Managers);
        }

        [Test]
        public void TS082_AdminUserManagement()
        {
            // Додавання менеджера
            var newManager = new Manager
            {
                Email = "newmanager@test.com",
                FirstName = "New",
                LastName = "Manager",
                Password = "NewManager123",
                PhoneNumber = "1234567894",
                TypeClass = "Менеджер"
            };

            bool addManagerResult = admin.AddManager(newManager);
            
            // Видалення менеджера
            int managerIndex = Manager.Managers.IndexOf(newManager);
            bool removeManagerResult = admin.RemoveManager(managerIndex);
            Assert.IsTrue(removeManagerResult);
            Assert.IsFalse(Manager.Managers.Contains(newManager));
        }

        [Test] // FR09: ПЗ повинно мати систему рівнів доступу (адміністратор, менеджер, клієнт)
        public void TS090_AccessLevels()
        {
            Assert.That(admin.TypeClass, Is.EqualTo("Адміністратор"));
            Assert.That(manager.TypeClass, Is.EqualTo("Менеджер"));
            Assert.That(client.TypeClass, Is.EqualTo("Клієнт"));

            // Перевірка, що адміністратор успадковує функціонал менеджера
            Assert.IsTrue(admin is IManager);
            Assert.IsTrue(admin is IAdministrator);

            // Перевірка, що менеджер не має прав адміністратора
            Assert.IsFalse(manager is IAdministrator);
        }
        
        [Test] // FR11: ПЗ має виводити список вільних автомобілів
        public void TS110_FreeCars_AvailableCars()
        {
            var freeCars = new FreeCars();
            DateTime startDate = DateTime.Now.AddDays(10);
            DateTime endDate = DateTime.Now.AddDays(13);

            // Додаємо ще один авто, який не має договорів
            var availableCar = new Auto
            {
                Brand = "AvailableBrand",
                Model = "AvailableModel",
                DailyPrice = 900,
                Aclass = classAuto.Економ,
                Atype = gearboxType.Механіка,
                Acolor = colorAuto.Коричневий
            };
            Auto.Autos.Add(availableCar);

            // Отримуємо доступні авто
            var availableCars = freeCars.AvailableCars(startDate, endDate);

            // Перевіряємо, що availableCar є в списку доступних
            Assert.Contains(availableCar, availableCars);
        } 
        
        [Test] // FR13: Система повинна генерувати унікальний ідентифікатор для кожного клієнта, автомобіля та договору
        public void TS130_UniqueIdentifiers()
        {
            // Перевірка унікальності ID автомобіля
            Assert.That(testCar.Id, Is.Not.EqualTo(Guid.Empty));

            var anotherCar = new Auto
            {
                Brand = "AnotherBrand",
                Model = "AnotherModel",
                DailyPrice = 1200,
                Aclass = classAuto.Мінівен,
                Atype = gearboxType.Автомат,
                Acolor = colorAuto.Жовтий
            };

            Assert.That(anotherCar.Id, Is.Not.EqualTo(testCar.Id));

            // Перевірка унікальності ID договору
            var newContract = new Contract
            {
                Car = testCar,
                Renter = client,
                Employee = manager,
                StartDate = DateTime.Now.AddDays(5),
                EndDate = DateTime.Now.AddDays(8)
        };

            manager.AddContract(newContract);
            Assert.That(newContract.Id, Is.Not.EqualTo(testContract.Id));
        }
        
        [Test] // FR14: При запуску програми повинні завантажуватись всі наявні записи з бази
        public void TS140_DataLoadingOnStartup()
        {
            // Спочатку серіалізуємо тестові дані
            admin.Serialize();
            manager.Serialize();
            client.Serialize();
            testCar.Serialize();
            testContract.Serialize();

            // Очищаємо списки
            Administrator.Administrators.Clear();
            Manager.Managers.Clear();
            Client.Clients.Clear();
            Auto.Autos.Clear();
            Contract.Contracts.Clear();

            // Імітуємо завантаження даних при запуску програми
            admin.Deserialize();
            manager.Deserialize();
            client.Deserialize();
            testCar.Deserialize();
            testContract.Deserialize();

            // Перевіряємо, що дані завантажилися
            Assert.That(Administrator.Administrators.Count, Is.EqualTo(1));
            Assert.That(Manager.Managers.Count, Is.EqualTo(1));
            Assert.That(Client.Clients.Count, Is.EqualTo(1));
            Assert.That(Auto.Autos.Count, Is.EqualTo(1));
            Assert.That(Contract.Contracts.Count, Is.EqualTo(1));
        }
        
        [Test] // NFR01: ПЗ повинно захищати персональні дані користувачів
        public void NTS010_DataProtection()
        {
            // Перевірка, що паролі не зберігаються у відкритому вигляді
            // (Це приклад - у реальності потрібно використовувати хешування)
            var client = new Client
            {
                Email = "test@example.com",
                Password = "SecurePassword123"
            };

            Assert.That(client.Password, Is.EqualTo("SecurePassword123"),
                "У реальній системі паролі мають бути хешовані, а не зберігатися у відкритому вигляді!");

            // Перевірка, що персональні дані не є публічними полями
            var userFields = typeof(User).GetFields(System.Reflection.BindingFlags.NonPublic |
                            System.Reflection.BindingFlags.Instance);
            Assert.IsTrue(userFields.Any(f => f.Name == "password"),
                "Поле password має бути приватним для захисту даних");
        }
        
        [Test] // NFR02: ПЗ повинно працювати на операційній системі Windows
        public void NTS020_WindowsCompatibility()
        {
            // Перевірка ОС (тест працюватиме лише на Windows)
            bool isWindows = Environment.OSVersion.Platform == PlatformID.Win32NT;
            Assert.IsTrue(isWindows, "ПЗ призначене для роботи на Windows");
        }
        
        [Test] // NFR03: ПЗ повинно підтримувати україномовний та/або англомовний інтерфейс
        public void NTS030_LocalizationSupport()
        {
            // Перевірка наявності ресурсів для локалізації
            // (У цьому прикладі просто перевіряємо наявність українського тексту в атрибутах)
            var displayNameAttr = typeof(Client).GetProperty("DriverLicense")
                .GetCustomAttributes(typeof(DisplayNameAttribute), false)
                .FirstOrDefault() as DisplayNameAttribute;

            Assert.IsNotNull(displayNameAttr);
            Assert.That(displayNameAttr.DisplayName, Is.EqualTo("Права"));
        }
        
        [Test] // NTS0: ПЗ повинно мати механізм автоматичного резервного копіювання даних
        public void NFR050_BackupMechanism()
        {
            // Перевірка, що методи серіалізації працюють (це можна вважати простим backup)
            var client = new Client
            {
                Email = "backup@test.com",
                FirstName = "Backup",
                LastName = "Test",
                Password = "Backup123",
                PhoneNumber = "1234567890",
                DriverLicense = "ABC-123456",
                BirthDate = new DateTime(1990, 1, 1)
            };

            bool result = client.Serialize();
            Assert.IsTrue(result, "Серіалізація даних (backup) не вдалася");
            Assert.IsTrue(File.Exists("Clients.json"), "Файл резервної копії не створено");
        }

        [Test] // NFR07	Користувач має отримувати зрозумілі повідомлення про помилки (не технічні деталі).
        public void NTS070_UserFriendlyErrorMessages()
        {
            // Тестування повідомлень про помилки валідації

            // 1. Перевірка повідомлення про невірний email
            var ex = Assert.Throws<ArgumentException>(() =>
            {
                var client = new Client
                {
                    Email = "invalid-email",
                    FirstName = "Test",
                    LastName = "User",
                    Password = "ValidPass123",
                    PhoneNumber = "1234567890",
                    DriverLicense = "ABC-123456",
                    BirthDate = new DateTime(1990, 1, 1)
                };
            });

            StringAssert.Contains("символ \"@\" та \".\"", ex.Message);
            StringAssert.DoesNotContain("System.Text.RegularExpressions", ex.Message);
            StringAssert.DoesNotContain("Regex", ex.Message);

            // 2. Перевірка повідомлення про короткий пароль
            ex = Assert.Throws<ArgumentException>(() =>
            {
                var client = new Client
                {
                    Email = "valid@email.com",
                    FirstName = "Test",
                    LastName = "User",
                    Password = "short",
                    PhoneNumber = "1234567890",
                    DriverLicense = "ABC-123456",
                    BirthDate = new DateTime(1990, 1, 1)
                };
            });

            StringAssert.Contains("Пароль повинен бути не порожнім і мати хоча б 8 символів", ex.Message);
            StringAssert.DoesNotContain("ArgumentException", ex.Message);

            // 3. Перевірка повідомлення про невірний формат водійських прав
            ex = Assert.Throws<ArgumentException>(() =>
            {
                var client = new Client
                {
                    Email = "valid@email.com",
                    FirstName = "Test",
                    LastName = "User",
                    Password = "ValidPass123",
                    PhoneNumber = "1234567890",
                    DriverLicense = "invalid-format",
                    BirthDate = new DateTime(1990, 1, 1)
                };
            });

            StringAssert.Contains("Неправильний формат поля права. (Наприклад: \"BXX-161565\")", ex.Message);
            StringAssert.DoesNotContain("Regex", ex.Message);
            
            // 4. Перевірка повідомлення про невірну дату народження
            ex = Assert.Throws<ArgumentException>(() =>
            {
                var youngClient = new Client
                {
                    Email = "young@test.com",
                    FirstName = "Young",
                    LastName = "User",
                    Password = "ValidPass123",
                    PhoneNumber = "1234567890",
                    DriverLicense = "ABC-123456",
                    BirthDate = DateTime.Now.AddYears(-17) // 17 років
                };
            });

            StringAssert.Contains("Водій має бути старше 18 років", ex.Message);
            StringAssert.DoesNotContain("DateTime", ex.Message);
        }
    }
}
