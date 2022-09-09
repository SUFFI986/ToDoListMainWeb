using Data_Transfer_Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ToDoListWebApplication.Models;

namespace ToDoListWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private Business_Acces_Layer.ToDoList_BAL _ListBAL;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,
                           Business_Acces_Layer.ToDoList_BAL toDoList_BAL )
        {
            _logger = logger;
            _ListBAL = toDoList_BAL ;
        }
        public IActionResult Index()
        {
            return View();
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
        [HttpGet]
        public IActionResult Create()
        {
            var model = new TaskItem();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                TaskItem newTask = new TaskItem
                {
                    Task = taskItem.Task,
                    Description = taskItem.Description,
                    Status = taskItem.Status,
                    Assgignee = taskItem.Assgignee,
                    Comments = taskItem.Comments,
                    Priority = taskItem.Priority,
                    Created = taskItem.Created,
                    CompleteBy = taskItem.CompleteBy,

                };
                _ListBAL.Add(newTask);
                return RedirectToAction("Details", new { id = newTask.Id });
            }

            return View(taskItem);
        }
    }
}