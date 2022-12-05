using eVent.Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace eVent.UnitTests
{
    [TestClass]
    public class CheckUserTests
    {
        private readonly string email = "test@gmail.com";
        private readonly string password = "testtest";

        [TestMethod]
        public void CheckUser_ShouldCheckUser_WhenAllParametersAreValid()
        {

            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.checkUser(email, password);

            //Assert
            Assert.IsTrue(result > 0);
        }
        private readonly string email2 = "marko@marko.marko";
        private readonly string password2 = "marko123";

        [TestMethod]
        public void CheckUser_ShouldCheckUser_WhenParametersAreInvalid()
        {

            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.checkUser(email2, password2);

            //Assert
            Assert.IsTrue(result < 0);
        }
    }
}