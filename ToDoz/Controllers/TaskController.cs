using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoz.ViewModels;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;



namespace ToDoz.Controllers

{
    /* Controller to manipulate Task Views*/
    [Authorize]
    public class TaskController : Controller
    {

        /*
        public async Task doSmth()
        {
            //...
        }
        */
       


        /* Returns a view of certain task */
        public IActionResult Task()
        {
            return View(new TaskViewModel()
            {
                //TO-DO
            });
        }

        /// <summary>
        /// This is just a helper action to enable you to easily see all claims related to a user. It helps when debugging your
        /// application to see the in claims populated from the Auth0 ID Token
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "admin")]
        public IActionResult Claims()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
