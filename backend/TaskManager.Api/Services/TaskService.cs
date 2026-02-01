using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Api.Models;

namespace TaskManager.Api.Services
{
    public class TaskService : ITaskService
    {
        public IEnumerable<TaskItem> GetAll()
        {
            return new List<TaskItem>
            {
                new TaskItem
                {
                    Id = 1,
                    Title = "Estudar ASP.NET Core",
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                },
                new TaskItem
                {
                    Id = 2,
                    Title = "Criar projeto Angular",
                    IsCompleted = false,
                    CreatedAt = DateTime.Now
                }
            };
        }
    }
}