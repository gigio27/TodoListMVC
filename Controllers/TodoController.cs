using Microsoft.AspNetCore.Mvc;
using TodoListMVC.Models;
using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoListMVC.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> taches = new List<TodoItem>();

        public IActionResult Index()
        {
            return View(taches);
        }
        [HttpGet]
        public IActionResult Add();
        {
            return View();
    }
    [HttpPost]
        public IactionResult Add(TodoItem item)
        {
            item.Id = taches.Count + 1;
            taches.Add(item);
            return RedirectToAction("Index");
        }
    }
}