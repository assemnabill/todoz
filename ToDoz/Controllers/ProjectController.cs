using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoz.Models;
using ToDoz.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoz.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {


        /* Method views Projects */
        public IActionResult Projects()
        {
            return View();
        }


        // GET: /<controller>/
        public IActionResult Create()
        {

            //return PartialView(new ProjectViewModel
            //{
            //    ProjectName = "New Project",
            //    ProjectImage = ProjectImage,
            //    Created = DateTime.Now,
            //    ProjectLeader = User.Identity.Name

            //});
            return View();
        }
    }
}
