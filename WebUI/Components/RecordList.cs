using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Components
{
    public class RecordList : ViewComponent
    {
        private readonly ApplicationContext _db;

        public RecordList(ApplicationContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var dt = _db.DateTimeRecords.Select(s=>s.Value).ToList();
            return View("RecordList", dt);
        }
    }
}