using System;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Components
{
    public class CurrentTime:ViewComponent
    {
        public string Invoke()
        {
            return $"Текущее время: {DateTime.Now:hh:mm:ss}";
        }
    }
}