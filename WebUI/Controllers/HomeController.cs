using Microsoft.AspNetCore.Mvc;
using System;
using WebUI.Services;


namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDateService _service;

        public HomeController(IDateService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Home/SaveValue")]
        public JsonResult Save(DateTime date)
        {
            if (date != DateTime.MinValue)
            {
                _service.Add(date);
                return Json(new { Message = "Success", result = 1 });
            }
            return Json(new { Message = "Error", result = 0 });
        }
    }
}
