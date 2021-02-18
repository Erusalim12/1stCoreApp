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
            var dt = _dateService.GetItemCollection();
            return View("RecordList", dt);
        }
    }
}