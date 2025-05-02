using RCLibrary;
using RCLibrary.Entities;
using System.Text.Json;

namespace Autonomous_Testing
{
    [TestFixture] //ToDo #4.7 Тести класу UserSystem
    internal class UserSystemTests
    {
        private UserSystem userSystem;
        private const string TestFilePath = "Users.json";

        [SetUp]
        public void Setup()
        {
            userSystem = new UserSystem();
            UserSystem.Users.Clear();
            UserSystem.activeUser = new UserSystem();

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

        [Test] //TCUS01
        public void TCUS01_Register_NewUser_AddsToUsersList()
        {
            var newUser = new Manager
            {
                Email = "new@user.com",
                Password = "ValidPass123"
            };

            bool result = userSystem.Register(newUser);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(result);
                Assert.That(UserSystem.Users, Has.Count.EqualTo(1).And.Contain(newUser));
            });
        }

        [Test] //TCUS02
        public void TCUS02_Register_DuplicateEmail_ReturnsFalse()
        {
            var user1 = new Manager { Email = "duplicate@user.com" };
            var user2 = new Manager { Email = "duplicate@user.com" };
            userSystem.Register(user1);

            bool result = userSystem.Register(user2);

            Assert.IsFalse(result);
            Assert.That(UserSystem.Users.Count, Is.EqualTo(1));
        }

        [Test] //TCUS03
        public void TCUS03_Register_DifferentUserTypes_AddsToUsersList()
        {
            var manager = new Manager { Email = "manager@test.com" };
            var client = new Client { Email = "client@test.com" };

            Assert.IsTrue(userSystem.Register(manager));
            Assert.IsTrue(userSystem.Register(client));
            Assert.That(UserSystem.Users.Count, Is.EqualTo(2));
        }

        [Test] //TCUS04
        public void TCUS04_Authenticate_ValidCredentials_ReturnsTrueAndSetsActiveUser()
        {
            var user = new Manager
            {
                Email = "test@user.com",
                Password = "ValidPass123"
            };
            userSystem.Register(user);

            bool result = userSystem.Authenticate("test@user.com", "ValidPass123");

            Assert.IsTrue(result);
            Assert.That(UserSystem.activeUser.Email, Is.EqualTo(user.Email));
        }

        [Test] //TCUS05
        public void TCUS05_Authenticate_AfterMultipleRegistrations_WorksCorrectly()
        {
            for (int i = 1; i <= 5; i++)
            {
                userSystem.Register(new Manager { Email = $"user{i}@test.com", Password = "validpass123" });
            }

            Assert.IsFalse(userSystem.Authenticate("user3@test.com", "pass"));
            Assert.IsFalse(userSystem.Authenticate("user3@test.com", "wrongpass"));
        }

        [Test] //TCUS06
        public void TCUS06_Authenticate_InvalidPassword_ReturnsFalse()
        {
            var user = new Manager
            {
                Email = "test@user.com",
                Password = "ValidPass123"
            };
            userSystem.Register(user);

            bool result = userSystem.Authenticate("test@user.com", "WrongPassword");

            Assert.IsFalse(result);
        }

        [Test] //TCUS07
        public void TCUS07_Authenticate_NonExistentEmail_ReturnsFalse()
        {
            bool result = userSystem.Authenticate("nonexistent@user.com", "anypassword");

            Assert.IsFalse(result);
        }

        [Test] //TCUS08
        public void TCUS08_Authenticate_SetsCorrectActiveUser()
        {
            var manager = new Manager { Email = "manager@test.com", Password = "validpass123" };
            var client = new Client { Email = "client@test.com", Password = "validpass123" };

            userSystem.Register(manager);
            userSystem.Register(client);

            userSystem.Authenticate("client@test.com", "validpass123");
            Assert.That(UserSystem.activeUser.Email, Is.EqualTo("client@test.com"));
        }

        [Test] //TCUS09
        public void TCUS09_Serialize_WithUsers_CreatesFile()
        {
            UserSystem.Users.Add(new Manager { Email = "test@user.com" });

            bool result = userSystem.Serialize();

            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(TestFilePath));
        }

        [Test] //TCUS10
        public void TCUS10_Deserialize_WithEmptyFile_CreatesEmptyList()
        {
            File.WriteAllText(TestFilePath, "");

            bool result = userSystem.Deserialize();

            Assert.IsTrue(result);
            Assert.That(UserSystem.Users.Count, Is.EqualTo(0));
        }

        [Test] //TCUS11
        public void TCUS11_Deserialize_CorruptedFile_ThrowsException()
        {
            File.WriteAllText(TestFilePath, "{invalid json}");
            Assert.Throws<JsonException>(() => userSystem.Deserialize());
        }
    }
}
