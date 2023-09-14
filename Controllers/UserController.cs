using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="sam",UserPwd="sam@1234",UserEmail="Sam@gmail.com" },
            new User(){UserId=2,UserName="Anit",UserPwd="anit@1234",UserEmail="anit@gmail.com" },
            new User(){UserId=3,UserName="kumar",UserPwd="kumar@1234",UserEmail="kumar@gmail.com" },
            new User(){UserId=4,UserName="Anisha",UserPwd="anisha@1234",UserEmail="anisha@gmail.com" },
            new User(){UserId=5,UserName="vidisha",UserPwd="vidisha@1234",UserEmail="vidisa@gmail.com" },
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
