using HelloWorld.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HelloWorldTests_NUnit
{
    [TestFixture]
    public class HelloWorldTests
    {
        [Test]
        public void HelloWorldTest()
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
