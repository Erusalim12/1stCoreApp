using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using WebUI.Models;
using WebUI.Models.Entity;


namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Home/SaveValue")]
        public IActionResult Save(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                var entity = new DateTimeEntity { Value = date };
                _db.DateTimeRecords.Add(entity);
                _db.SaveChanges();
                return Json(new { Message = "Success", result = 1 });
            }


            return Json(new { Message = "Error", result = 0 });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
