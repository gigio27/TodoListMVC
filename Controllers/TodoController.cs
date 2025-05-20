using Microsoft.AspNetCore.Mvc;
using TodoListMVC.Models;
using System.Collections.Generic;

namespace TodoListMVC.Controllers
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
            // Console.WriteLine($"DEBUG → Title: {item.Title}, IsDone: {item.IsDone}");
            item.Id = tasks.Count + 1;
            tasks.Add(item);
            return RedirectToAction("Index");
        }

    }
}