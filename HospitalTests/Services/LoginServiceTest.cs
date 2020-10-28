using HospitalServer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HospitalTests.Services
{
    [TestClass]
    public class LoginServiceTest : BaseTest
    {
        private LoginService _loginService;

        [TestInitialize()]
        public void SetUp()
        {
            BaseSetup();
            _loginService = new LoginService(contextMock.Object);
        }

        [TestMethod]
        public void LoginValidTest()
        {
            var email = "antoine@fail.com";
            var password = "toto";

            var response = _loginService.Login(email, password);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void LoginInvalidTest()
        {
            var email = "nonexistingmail@fail.com";
            var password = "toto";

            var response = _loginService.Login(email, password);

            Assert.IsNull(response);
        }

        [TestMethod]
        public void LoginValidEmailInvalidPasswordTest()
        {
            var email = "antoine@fail.com";
            var password = "incorrect";

            var response = _loginService.Login(email, password);

            Assert.IsNull(response);
        }

        [TestMethod]
        public void SignupValidTest()
        {
            var email = "newuser@fail.com";
            var password = BCrypt.Net.BCrypt.HashPassword("toto");
            var firstName = "New";
            var lastName = "User";

            var isAdded = _loginService.Signup(email, password, firstName, lastName);

            Assert.IsTrue(isAdded);
        }

        [TestMethod]
        public void SignupInvalidTest()
        {
            var email = "denis@fail.com";
            var password = BCrypt.Net.BCrypt.HashPassword("toto");
            var firstName = "New";
            var lastName = "Existing user";

            var isAdded = _loginService.Signup(email, password, firstName, lastName);

            Assert.IsFalse(isAdded);
        }
    }
}
