using RCLibrary.Entities;
using RCLibrary;

namespace Acceptance_Testing
{
    [TestFixture]
    internal class EmailUniquenessTests
    {
        private UserSystem userSystem;

        [SetUp]
        public void Setup()
        {
            userSystem = new UserSystem();
            userSystem.Register(new Client { Email = "existing@test.com" });
        }

        // FR12: Унікальний email
        [Test]
        public void FR12_Email_Unique_ShouldRegisterSuccessfully()
        {
            var newClient = new Client { Email = "new@test.com" };
            Assert.IsTrue(userSystem.Register(newClient));
        }

        // FR12: Дублювання email
        [Test]
        public void FR12_Email_Duplicate_ShouldReturnFalse()
        {
            var duplicateClient = new Client { Email = "existing@test.com" };
            Assert.IsFalse(userSystem.Register(duplicateClient));
        }
    }
}
