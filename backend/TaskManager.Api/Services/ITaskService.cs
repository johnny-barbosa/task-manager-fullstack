using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Api.Models;

namespace TaskManager.Api.Services
{
    public interface ITaskService
    {
         IEnumerable<TaskItem> GetAll();
    }
}