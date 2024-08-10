using ListaDeTarefasWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListaDeTarefasWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TasksDbContext _context;

        public HomeController(ILogger<HomeController> logger, TasksDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tasks()
        {
            var allTasks = _context.Tasks.ToList();
            return View(allTasks);
        }
        public IActionResult CreateEditTask()
        {
            return View();
        }

        public IActionResult CreateEditTaskForm(Models.Task taskModel)
        {
            _context.Tasks.Add(taskModel);  
            _context.SaveChanges();
            return RedirectToAction("Tasks");
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
    }
}
