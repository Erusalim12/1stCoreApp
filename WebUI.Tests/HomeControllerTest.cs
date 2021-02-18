
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebUI.Controllers;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _hc;
        [TestInitialize]
        public void Prepare()
        {
            Mock<IDateService> mock = new Mock<IDateService>();
            mock.Setup(m => m.GetItemCollection()).Returns(new List<DateTime>
            {
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue,
                DateTime.UtcNow
            });

            _hc = new HomeController(mock.Object);
            Assert.IsNotNull(_hc);

        }

        [TestMethod]
        public void CanGetIndexPage()
        {
            var result = _hc.Index();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanSaveValidValues()
        {
            var result = _hc.Save(DateTime.Now);
            Assert.AreEqual(result.Value.ToString(), "{ Message = Success, result = 1 }");
        }
    }
}
