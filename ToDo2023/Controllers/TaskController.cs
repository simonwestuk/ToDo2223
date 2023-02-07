using Microsoft.AspNetCore.Mvc;
using ToDo2023.Models;

namespace ToDo2023.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Add(TaskModel task)
        {
            return View();
        }
    }
}
