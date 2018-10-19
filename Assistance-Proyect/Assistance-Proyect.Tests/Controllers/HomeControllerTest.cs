using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assistance_Proyect;
using Assistance_Proyect.Controllers;
using Assistance_Proyect.ViewModels;

namespace Assistance_Proyect.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Calculator()
        { 
            CalcViewModel data = new CalcViewModel();
            HomeController c = new HomeController();
            data.NumberA = 2;
            data.NumberB = 2;
            data.Operator = Operator.Add;
            ViewResult result = c.Calculator(data) as ViewResult;
            var VmResult = result.Model as CalcViewModel;
            Assert.AreEqual(4, VmResult.Result);
        }
    }
}
