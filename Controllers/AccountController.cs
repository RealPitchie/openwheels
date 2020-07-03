using System.Security.Claims;
using System.Threading.Tasks;
using yapf1.Models;
using yapf1.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace yapf1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        IWebHostEnvironment _appEnvironment;
 
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model, IFormFile imageFile)
        {
            if(ModelState.IsValid) 
            {
                AppUser user = new AppUser { Email = model.Email, UserName = model.Email, Name=model.Name, UserAvatar = model.UserAvatar};

                if(imageFile != null)
                {
                    string path = "/Files/Images/Avatars/" + imageFile.FileName;
                    if (!Directory.Exists (_appEnvironment.WebRootPath + "/Files/Images/Avatars/")) 
                    {
                        Directory.CreateDirectory (_appEnvironment.WebRootPath + "/Files/Images/Avatars/");
                    }
                    using (var fileStream = new FileStream (_appEnvironment.WebRootPath + path, FileMode.Create)) 
                    {
                        imageFile.CopyTo(fileStream);
                    }
                    user.UserAvatar = path;
                }else user.UserAvatar = "";
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    await _userManager.AddClaimAsync(user, new Claim("Name", user.Name)); 
                    await _userManager.AddClaimAsync(user, new Claim("UserAvatar", user.UserAvatar)); 
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    // проверяем, принадлежит ли URL приложению
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}