using System;
using System.Collections.Generic;

namespace WebUI.Services
{
    public interface IDateService
    {
        void Add(DateTime dt);
        IEnumerable<DateTime> GetItemCollection();
    }
}