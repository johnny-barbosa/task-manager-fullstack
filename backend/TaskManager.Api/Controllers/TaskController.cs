using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Models;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var tasks = new List<TaskItem>
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

            return Ok(tasks);
        }
    }
}