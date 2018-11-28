using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Repository;


namespace src.Controllers
{
    [Route("[controller]")]
    public class TaskController : Controller
    {
        
        private TaskRepository repository;
        public TaskController(){
            repository = new TaskRepository();
        }


        [HttpGet]
        public IActionResult Get(){
           return Ok(repository.GetAllTasks());
        }

        
    }
}
