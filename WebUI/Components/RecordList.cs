using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Components
{
    public class RecordList : ViewComponent
    {
        //private readonly AppDbContext _context;
        //public RecordList(DbContext context)
        //{
        //    _context = context;
        //}

        public IViewComponentResult Invoke()
        {
            // todo: через DI получать значение из базы данных и выводить его на View
            var dt = new List<DateTime> {DateTime.MinValue, DateTime.Now, DateTime.MaxValue};
            return View("RecordList", dt);
        }
    }
}