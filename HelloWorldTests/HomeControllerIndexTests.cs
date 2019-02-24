using System;
using System.Web.Mvc;
using HelloWorld.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTests
{
    [TestClass]
    public class HomeControllerIndexTests
    {
        [TestMethod]
        public void HomeIndexTests()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Hello, World!", result.ViewBag.Message);
        }
    }
}
