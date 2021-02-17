using System;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Components
{
    public class CurrentDate:ViewComponent
    {
        public string Invoke()
        {
            return $"{DateTime.Now}";
        }
    }
}