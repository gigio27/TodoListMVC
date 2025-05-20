using Microsoft.AspNetCore.Mvc;
using TodoListMVC.Models;
using System.Collections.Generic;

namespace ToDoListMVC.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> tasks = new List<TodoItem>();

        public IActionResult Index()
        {
            return View(tasks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
    }
    [HttpPost]
        public IActionResult Add(TodoItem item)
        {
            item.Id = tasks.Count + 1;
            tasks.Add(item);
            return RedirectToAction("Index");
        }
    }
}