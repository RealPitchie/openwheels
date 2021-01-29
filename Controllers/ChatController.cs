using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using openwheels.Models;

namespace openwheels.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly BlogContext _blogContext;
        private readonly ApplicationContext _appContext;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _appEnvironment;

        public ChatController(ILogger<HomeController> logger, BlogContext blogContext,
                ApplicationContext appContext, IWebHostEnvironment appEnvironment, BlogContext blogContext2)
        {
            _logger = logger;
            _blogContext = blogContext;
            _appContext = appContext;
            _appEnvironment = appEnvironment;
            _blogContext = blogContext2;
        }

        public IActionResult Index()
        {
            ClaimsPrincipal currentUser = this.User;
            if(currentUser.FindFirst("Name").Value == null)
            {
                return NotFound();
            }else{
                ViewBag.UserName = currentUser.FindFirst("Name").Value;
            return View();
            }
        }
    }
}