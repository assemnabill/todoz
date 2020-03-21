using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
