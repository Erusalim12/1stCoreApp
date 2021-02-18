using System;
using System.Collections.Generic;
using System.Linq;
using WebUI.Models;
using WebUI.Models.Entity;

namespace WebUI.Services
{
    public class DateService : IDateService
    {
        private readonly ApplicationContext _context;

        public DateService(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(DateTime dt)
        {
            var entity = new DateTimeEntity
            {
                Value =  dt
            };
            _context.DateTimeRecords.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<DateTime> GetItemCollection()
        {
            return _context.DateTimeRecords.Select(s => s.Value);
        }
    }
}