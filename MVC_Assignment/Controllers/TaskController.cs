using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;
using MVC_Assignment.Services;



namespace TaskManagementProject.Controllers
{
    public class TaskController : Controller
    {
        static int count = 1;
        [HttpGet]
        public IActionResult Index()
        {
            TaskViewModel taskViewModel = new TaskViewModel();
            taskViewModel.AssigneeNameList = TaskService.GetAllAssignee();
            taskViewModel.TasksList = TaskService.GetTasks();

            return View(taskViewModel);
        }


        [HttpPost]
        public IActionResult Index(string SelectedAssignee)
        {
            TaskViewModel taskViewModel1 = new TaskViewModel();
            taskViewModel1.AssigneeNameList = TaskService.GetAllAssignee();
            taskViewModel1.TasksList = TaskService.GetTasksByAssignee(SelectedAssignee);
            
            return View(taskViewModel1);
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
                      
                TaskService.AddTask(task);
                return RedirectToAction("Index");
           
        }

        [HttpGet]
        public IActionResult Create()
        {
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
