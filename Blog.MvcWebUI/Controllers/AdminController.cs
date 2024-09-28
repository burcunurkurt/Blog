
using Blog.MvcWebUI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blog.MvcWebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;

        public AdminController(UserManager<CustomIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
