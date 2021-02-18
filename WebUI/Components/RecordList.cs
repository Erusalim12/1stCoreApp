using System;
using Microsoft.AspNetCore.Mvc;
using WebUI.Services;

namespace WebUI.Components
{
    public class RecordList : ViewComponent
    {
        private readonly IDateService _dateService;
        
        public RecordList(IDateService dateService)
        {
            _dateService = dateService;
        }
        public IViewComponentResult Invoke()
        {
            if (_dateService != null)
            {
                var dt = _dateService.GetItemCollection();
                // ReSharper disable once Mvc.ViewComponentViewNotResolved
                //path: ~/Views/{controller}/components/{componentName}/{viewName}
                return View("RecordList", dt);
            }
            throw  new NullReferenceException();
        }
    }
}