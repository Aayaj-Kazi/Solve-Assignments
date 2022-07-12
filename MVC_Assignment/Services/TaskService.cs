using MVC_Assignment.Models;

using System;
using System.Collections.Generic;
using System.Linq;



namespace MVC_Assignment.Services
{
    public static class TaskService
    {
        private static List<Task> tasksList = new List<Task>();

        static int count = 1;
        public static void AddTask(Task task)
        {
            tasksList.Add(
            new Task { TaskId= count, Title=task.Title,  Description=task.Description, 
                AssigneeName = task.AssigneeName, Complitation_Date =task.Complitation_Date});
            count++;
            //tasksList.Add(task);
        }

        public static void UpdateTask(Task task)
        {
            var matchedTasks = tasksList.Where(m => m.TaskId == task.TaskId).ToList();
            matchedTasks.ForEach(m =>
            {
                m.Title = task.Title;
                m.Description = task.Description;
                m.AssigneeName = task.AssigneeName;
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

        

        public static List<string> GetAllAssignee()
        {
            var assigneeNames = tasksList.Select(s => s.AssigneeName).Distinct();
            return assigneeNames.ToList();

        }

        public static List<Task> GetTasksByAssignee(string assigneeName)
        {
            var taksByAssignee = tasksList.Where(s => s.AssigneeName == assigneeName);

            return taksByAssignee.ToList();
        }
    }
}
