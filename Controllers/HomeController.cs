using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private DBContext context;
        private PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        private PasswordHasher<LoginUser> LoginHasher = new PasswordHasher<LoginUser>();

        public HomeController(DBContext dbc)
        {
            context = dbc;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                u.Password = RegisterHasher.HashPassword(u, u.Password);
                context.Users.Add(u);
                context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", u.UserId);
                HttpContext.Session.SetString("UserName", u.Name);

                return Redirect("/bright_ideas");
            }
            return View("Index");
        }
        [HttpPost("login")]
        public IActionResult Login(LoginUser l)
        {
            if (ModelState.IsValid)
            {
                User logging_in_user = context.Users.FirstOrDefault(u => u.Email == l.LoginEmail);
                if (logging_in_user != null)
                {
                    var result = LoginHasher.VerifyHashedPassword(l, logging_in_user.Password, l.LoginPassword);
                    if (result == 0)
                    {
                        ModelState.AddModelError("LoginPassword", "Password");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("UserId", logging_in_user.UserId);
                        HttpContext.Session.SetString("UserName", logging_in_user.Name);
                        return Redirect("/bright_ideas");
                    }
                }
                else
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email");
                }
            }
            return View("Index");
        }
        [HttpGet("bright_ideas")]
        public IActionResult Bright_Ideas()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return Redirect("/");
            }
            string Username = HttpContext.Session.GetString("UserName");
            ViewBag.UserId = UserId;
            ViewBag.Username = Username;
            ViewBag.Ideas = context.Ideas
                .Include(i => i.Poster)
                // .ThenInclude(i => i.UserId)
                .Include(i => i.UsersLiking)
                .OrderByDescending(i => i.UsersLiking.Count);
            

            return View();
        }
        [HttpGet("logout")]
        public IActionResult Logout(){
            HttpContext.Session.Remove("UserId");
            return Redirect("/");
        }
        [HttpPost("NewIdea")]
        public IActionResult NewIdea(Idea i)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return Redirect("/");
            }
            if(ModelState.IsValid)
            {
                i.UserId = (int) UserId;
                context.Ideas.Add(i);
                context.SaveChanges();
                return Redirect("/Bright_Ideas");
            }
            else
            {
                return Redirect("/Bright_Ideas");
            }
        }
        [HttpGet("delete/{IdeaId}")]
        public IActionResult Delete(int IdeaId)
        {
            Idea lk = context.Ideas.FirstOrDefault(l => l.IdeaId == IdeaId);
            context.Ideas.Remove(lk);
            context.SaveChanges();
            return Redirect("/Bright_Ideas");
        }
        [HttpGet("like/{IdeaId}")]
        public IActionResult Like(int ideaId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            Like l = new Like(){
                UserId = (int)UserId,
                IdeaId = ideaId
            };
            context.Likes.Add(l);
            context.SaveChanges();
            return Redirect("/Bright_Ideas");
        }
        [HttpGet("view/{IdeaId}")]
        public IActionResult ShowLikes(int IdeaId)
        {
            Idea lk = context.Ideas
            .Include(l => l.UsersLiking)
            .ThenInclude(l => l.Liker)
            .Include(l => l.Poster)
            .FirstOrDefault(l => l.IdeaId == IdeaId);
            // User UserWhoPosted = context.Users.FirstOrDefault(u => u.UserId == UserId);
            // ViewBag.UserWhoPosted = UserWhoPosted;
            ViewBag.Likes = lk.UsersLiking;
            ViewBag.Poster = lk.Poster;
            return View(lk);
        }
        [HttpGet("viewuser/{UserId}")]
        public IActionResult Profile(int userId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if (UserId == null)
            {
                return Redirect("/");
            }
            ViewBag.ViewUser = context.Users.Where(u => u.UserId == userId)
                .Include(u => u.UserIdeas)
                .Include(u => u.IdeasLiked)
                .Single();
            return View();
        }
    }
}
