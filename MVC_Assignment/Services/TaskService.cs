using MVC_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MVC_Assignment.Models;

namespace MVC_Assignment.Services
{
    public static class TaskService
    {
        private static List<Task> tasksList = new List<Task>();
        public static void AddTask(Task task)
        {
            tasksList.Add(task);
        }

        public static void UpdateTask(Task task)
        {
            var matchedTasks = tasksList.Where(m => m.TaskId == task.TaskId).ToList();
            matchedTasks.ForEach(m =>
            {
                m.Title = task.Title;
                m.Description = task.Description;
                m.Assignee = task.Assignee;
                m.Complitation_Date = task.Complitation_Date;

            });
        }

        public static void DeleteTask(int taskId)
        {
            tasksList.RemoveAll(m => m.TaskId == taskId);
        }

        public static List<Task> GetTasks()
        {
            return tasksList;
        }
        public static Task GetTaskById(int id)
        {
            return tasksList.Find(m => m.TaskId == id);
        }
    }
}
