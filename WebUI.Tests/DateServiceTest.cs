using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Tests
{
    [TestClass]
    public class DateServiceTest
    {
        private DateService service;
        [TestInitialize]
        public void Prepare()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseInMemoryDatabase("testdb");
            var _dbContext = new ApplicationContext(optionsBuilder.Options);
            service = new DateService(_dbContext);
        }

        [TestMethod]
        public void CanFillData()
        {
            try
            {
                service.Add(DateTime.MinValue);
                service.Add(DateTime.Now);
                service.Add(DateTime.MaxValue);
                service.Add(DateTime.Now);
            }
            catch(DbUpdateException)
            {
                Assert.Fail("Данные не добавлены");
            }

            
        }
        [TestMethod]
        public void ReadData()
        {
            var count = service.GetItemCollection().Count(c => c <= DateTime.Now);
            Assert.AreEqual(count,3);
        }
         
    }
}
