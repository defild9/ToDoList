using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ToDoItem _context;

        public HomeController(ILogger<HomeController> logger, ToDoItem context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult AddToDo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToDo(ToDo todo)
        {
            _context.Add(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditToDo(int id)
        {
            return View(_context.ToDos.Find(id));
        }
        [HttpPost]
        public IActionResult EditToDo(ToDo todo)
        {
            _context.Update(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(_context.ToDos.ToList());
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
