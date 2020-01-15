using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoz.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoz.Controllers
{
    public class ProcessController : Controller
    {
        // adds a Connection between 2 Flow Object instances
        public IActionResult Connect()
        {
            return View(new ProcessViewModel());
        }

        // removes a Connection between 2 Flow Object instances
        public IActionResult Disconnect()
        {
            return View(new ProcessViewModel());
        }


    }
}
