using Microsoft.AspNetCore.Mvc;
using ToDo2023.Data;
using ToDo2023.Models;

namespace ToDo2023.Views
{
    public class UserController : Controller
    {


        private readonly AppDbContext _db;
        private UserModel _user;
        public UserController(AppDbContext db, UserModel user) //Dependency Injection
        {
            _db = db;
            _user = user;
        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(UserModel user)
        {

            if (user == null)
            {
                return NotFound();
            }

           if (ModelState.IsValid)
           {
               
                _db.Users.Add(user);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Login));

           }

           return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }   
        
        [HttpPost]
        public IActionResult Login(UserModel? user)
        {
            if (user == null)
            {
                return NotFound();
            }

            if (user.Email == null)
            {
                ModelState.AddModelError("Email", "Email not provided.");
                return View(user);
            }
            if (user.Password == null)
            {
                ModelState.AddModelError("Password", "Password not provided.");
                return View(user);
            }

            //Get user from database

            UserModel userFromDb = _db.Users.FirstOrDefault(m => user.Email == m.Email);

            if (userFromDb == null)
            {
                ModelState.AddModelError("Email", "Email not found.");
                return View(user);
            }
            
            if (userFromDb.Password.Equals(user.Password))
            {
                _user = userFromDb;
                return RedirectToAction("Index", "Task");
            }
            else
            {
                ModelState.AddModelError("Password", "Password is incorrect.");
                return View(user);
            }

            return View();
        }

    }
}
