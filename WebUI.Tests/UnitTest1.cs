using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebUI.Services;

namespace WebUI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DateServiceCanCreate()
        {
            var dateService = new DateService();
            Assert.IsNotNull(dateService);
        }
    }
}
