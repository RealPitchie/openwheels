using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using yapf1.Models;

namespace yapf1.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        BlogContext _blogContext;
        ApplicationContext _appContext;
        private readonly ILogger<HomeController> _logger;
        IWebHostEnvironment _appEnvironment;

        public ChatController(ILogger<HomeController> logger, BlogContext blogContext, 
                ApplicationContext appContext, IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _blogContext = blogContext;
            _appContext = appContext;
            _appEnvironment = appEnvironment;
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