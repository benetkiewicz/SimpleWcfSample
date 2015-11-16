namespace ManualWcf.ClientTests
{
    using ManualWcf.Client;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void LoadAllUsersTest()
        {
            var sut = new UserManagingServiceClient();
            var users = sut.GetAllUsers();
            Assert.IsNotNull(users);
            Assert.AreEqual(1, users.Count);
        }
    }
}
