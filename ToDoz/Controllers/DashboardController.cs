using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoz.Models;


namespace ToDoz.Controllers
{
    
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        /*
        // Inside one of your controller actions

            if (User.Identity.IsAuthenticated)
                {
            string accessToken = await HttpContext.GetTokenAsync("access_token");

        // if you need to check the Access Token expiration time, use this value
        // provided on the authorization response and stored.
        // do not attempt to inspect/decode the access token
            DateTime accessTokenExpiresAt = DateTime.Parse(
                await HttpContext.GetTokenAsync("expires_at"),
                CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind);

            string idToken = await HttpContext.GetTokenAsync("id_token");

        // Now you can use them. For more info on when and how to use the
        // Access Token and ID Token, see https://auth0.com/docs/tokens
                }
    */

    /* Method views Dashboard */
    public IActionResult Index()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
