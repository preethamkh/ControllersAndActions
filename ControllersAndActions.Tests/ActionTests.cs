using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            ViewResult result = target.Index();

            // Assert - check the result
            Assert.AreEqual("Homepage", result.ViewName);
        }

        [TestMethod]
        public void ViewSelectionTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();

            // Act - call the action method
            ViewResult result = target.Index();

            // Assert - check the result
            Assert.AreEqual("", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        }
    }
}
