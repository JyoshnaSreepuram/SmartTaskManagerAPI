using Microsoft.AspNetCore.Mvc;
using SmartTaskManagerAPI.Models;
using SmartTaskManagerAPI.Services;


namespace SmartTaskManagerAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {

        private readonly TaskService _taskService;


        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }



        // GET: api/tasks
        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(_taskService.GetTasks());
        }



        // GET api/tasks/1
        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {

            var task = _taskService.GetTaskById(id);


            if(task == null)
                return NotFound();


            return Ok(task);

        }




        // POST api/tasks
        [HttpPost]
        public IActionResult CreateTask(TaskItem task)
        {

            var result = _taskService.AddTask(task);

            return Ok(result);

        }




        // PUT api/tasks/1
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, TaskItem task)
        {

            var result = _taskService.UpdateTask(id, task);


            if(result == null)
                return NotFound();


            return Ok(result);

        }




        // DELETE api/tasks/1
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {

            var result = _taskService.DeleteTask(id);


            if(!result)
                return NotFound();


            return Ok("Task Deleted Successfully");

        }


    }
}
