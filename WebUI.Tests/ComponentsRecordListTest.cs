using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebUI.Components;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.Tests
{
    [TestClass]
    public class ComponentsRecordListTest
    {

        private ApplicationContext context;
        [TestInitialize]
        public void Prepare()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseInMemoryDatabase("testdb");
            context = new ApplicationContext(optionsBuilder.Options);
            
        }
        [TestMethod]
        public void CanInvoke()
        {
            Mock<IDateService> mock = new Mock<IDateService>();
            mock.Setup(m => m.GetItemCollection()).Returns(new List<DateTime>
            {
                DateTime.MinValue,
                DateTime.Now,
                DateTime.MaxValue,
                DateTime.UtcNow 
            });

            var rl = new RecordList(mock.Object).Invoke();
                //todo проверять содержимое представления, а не его наличие
            Assert.IsNotNull(rl);
        }
    }
}