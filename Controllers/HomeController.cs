using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using yapf1.Models;
using yapf1.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Collections;

namespace yapf1.Controllers
{
    public class HomeController : Controller
    {
        BlogContext _blogContext;
        ApplicationContext _appContext;
        private readonly ILogger<HomeController> _logger;
        IWebHostEnvironment _appEnvironment;

        public HomeController(ILogger<HomeController> logger, BlogContext blogContext, ApplicationContext appContext, IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _blogContext = blogContext;
            _appContext = appContext;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            int pageSize = 3;   // количество элементов на странице
            var source = _blogContext.Longreads.Select(l => l).OrderByDescending(l => l.Posted);
             
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToArrayAsync();
             
            
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            Indexv2ViewModel viewModel = new Indexv2ViewModel
            {
                PageViewModel = pageViewModel,
                Posts = items
            };
             
            
            return View(viewModel); 
        }  
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddPost()
        {
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddPost(Post newPost, IFormFile imageFile)
        {
            if(newPost != null)
            {
                using(_blogContext)
                {
                    if(imageFile != null)
                    {
                        string path = "/Files/Images/" + imageFile.FileName;
                        if (!Directory.Exists (_appEnvironment.WebRootPath + "/Files/Images/")) {
                            Directory.CreateDirectory (_appEnvironment.WebRootPath + "/Files/Images/");
                        }
                        // сохраняем файл в папку Files в каталоге wwwroot
                        using (var fileStream = new FileStream (_appEnvironment.WebRootPath + path, FileMode.Create)) {
                            imageFile.CopyTo(fileStream);
                        }
                        newPost.ImageFile = path;
                    }
                    newPost.Posted = DateTime.Now;
                    newPost.Id = Guid.NewGuid().ToString();
                    ClaimsPrincipal currentUser = this.User;
                    newPost.AuthorAvatar = currentUser.FindFirst("UserAvatar").Value;
                    newPost.Author = currentUser.FindFirst("Name").Value;
                     
                    
                    _blogContext.Posts.Add(newPost);
                    _blogContext.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult PostView(string id)
        {
            if(id == null)
                return NotFound();
            using(_blogContext)
            {

                var targetPost = (from p in _blogContext.Longreads where p.Id == id select p).FirstOrDefault();
                if(targetPost == null) return NotFound();
                ViewBag.Comments = _blogContext.Comments.Where(c => c.PostId == id).OrderBy(c => c.Posted).ToList();
                targetPost.Rating++;
                _blogContext.SaveChanges();
                
                return View(targetPost);
            }
            
        }
        public IActionResult _GetComments(string id)
        {
            using(_blogContext)
            {
                var comments = (from c in _blogContext.Comments where c.PostId == id select c).OrderBy(c => c.Posted).ToList();

                return PartialView(comments);
            }
        }
        [Authorize]
        public IActionResult AddComment(string id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddComment(Comment NewComment, string postId, IFormFile cameraVideo, IFormFile imageFile)
        {
            if(NewComment != null)
            {
                using(_blogContext)
                {
                    if(imageFile != null)
                    {
                        string path = "/Files/Comments/Images/" + imageFile.FileName;
                        if (!Directory.Exists (_appEnvironment.WebRootPath + "/Files/Comments/Images/")) {
                            Directory.CreateDirectory (_appEnvironment.WebRootPath + "/Files/Comments/Images/");
                        }
                        // сохраняем файл в папку Files в каталоге wwwroot
                        using (var fileStream = new FileStream (_appEnvironment.WebRootPath + path, FileMode.Create)) {
                            imageFile.CopyTo(fileStream);
                        }
                        NewComment.ImageFile = path;
                    }
                    var post = _blogContext.Longreads.Where(p => p.Id == postId).Select(p => p).FirstOrDefault();
                    NewComment.Posted = DateTime.Now;
                    NewComment.LongreadId = post.Id;
                    NewComment.Id = Guid.NewGuid().ToString();
                    ClaimsPrincipal currentUser = this.User;
                    NewComment.AuthorAvatar = currentUser.FindFirst("UserAvatar").Value;
                    NewComment.Author = currentUser.FindFirst("Name").Value;
                    NewComment.PostId = postId;
                    
                    _blogContext.Comments.Add(NewComment);
                    _blogContext.SaveChanges();
                }
            }

            return Redirect(Request.Headers["Referer"].ToString() + "#comments-partial");
        }


        public IActionResult Forum()
        {
            return View();
        }
        public IActionResult _GetBestPosts()
        {
            using(_blogContext)
            {
                var posts = (from p in _blogContext.Posts select p).OrderByDescending(p => p.Rating).Take(3).ToList();

                return PartialView(posts);
            }
        }

        public IActionResult _GetNewComments()
        {
            using(_blogContext)
            {
                var comments = (from c in _blogContext.Comments select c).OrderByDescending(c => c.Posted).Take(3).ToList();
                var postsAffected = new List<Longread>();
                foreach(var comm in comments)
                {
                    var targetPost = _blogContext.Longreads.Where(p => p.Id == comm.LongreadId).Select(p => p).FirstOrDefault();
                    postsAffected.Add(targetPost);
                }
                ViewBag.PostsAffected = postsAffected;

                return PartialView(comments);
            }
        }

        //Longreads
        [HttpGet]
        public IActionResult AddLongread()
        {
            var lr = new Longread();

            return PartialView(lr);
        }
        [HttpPost]
        public IActionResult AddLongread(Longread longread, IFormFile[] imageFile, string[] text, string videolink)
        {
            using(_blogContext)
            {
                Longread lr = longread;
                if(imageFile != null)
                {
                    List<string> filenames = new List<string>();
                    foreach(var img in imageFile)
                    {
                        string path = "/Files/Longreads/Images/" + img.FileName;
                        if (!Directory.Exists (_appEnvironment.WebRootPath + "/Files/Longreads/Images/")) {
                            Directory.CreateDirectory (_appEnvironment.WebRootPath + "/Files/Longreads/Images/");
                        }
                        // сохраняем файл в папку Files в каталоге wwwroot
                       if(!System.IO.File.Exists(path))
                       {
                            
                            using (var fileStream = new FileStream (_appEnvironment.WebRootPath + path, FileMode.Create)) {
                                img.CopyTo(fileStream);
                            }
                       }else
                       {
                           path = "/Files/Longreads/Images/" + img.FileName + Guid.NewGuid().ToString();
                            using (var fileStream = new FileStream (_appEnvironment.WebRootPath + path + Guid.NewGuid().ToString(), FileMode.Create)) {
                                img.CopyTo(fileStream);
                            }
                       }
                        filenames.Add(path);
                    }
                    lr.ImageFile = filenames.ToArray();
                }
                
                lr.Posted = DateTime.Now;
                lr.Id = Guid.NewGuid().ToString();
                ClaimsPrincipal currentUser = this.User;
                lr.AuthorAvatar = currentUser.FindFirst("UserAvatar").Value;
                lr.Author = currentUser.FindFirst("Name").Value;
                
                 
                lr.Text = text;
               
                lr.VideoLink = videolink;
                
                _blogContext.Add(lr);
                _blogContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
