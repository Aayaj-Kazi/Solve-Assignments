using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;
using MVC_Assignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;



namespace TaskManagementProject.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View(TaskService.GetTasks());
        }

        public IActionResult Create(Task task)
        {
            if (task.TaskId > 0) {
                TaskService.AddTask(task);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(TaskService.GetTaskById(id));
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (task.TaskId > 0)
            {
                TaskService.UpdateTask(task);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
