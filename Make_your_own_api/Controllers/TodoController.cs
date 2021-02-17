using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Make_your_own_api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Make_your_own_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }


        // CRUD      SQL          HTTP
        //
        // CREATE    INSERT       POST
        // READ      SELECT       GET
        // UPDATE    UPDATE       PUT
        // DELETE    DELETE       DELETE

        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<TodoApiModel> Get()
        {
            return _todoService.Todos;
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public TodoApiModel Get(int id)
        {
            return _todoService.Todos
                .FirstOrDefault(todo => todo.Id == id);
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] TodoApiModel model)
        {
            _todoService.Todos.Add(model);
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TodoApiModel model)
        {
            var todoItem = _todoService.Todos
                .FirstOrDefault(todo => todo.Id == id);

            todoItem.IsComplete = model?.IsComplete ?? todoItem.IsComplete;
            todoItem.Name = model?.Name ?? todoItem.Name;
            todoItem.Description = model?.Description ?? todoItem.Description;
            //       null chain operator: ^             ^ :null coelesce       
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var todoItem =  _todoService.Todos
                .FirstOrDefault(todo => todo.Id == id);

            if (todoItem != null)
            {

                _todoService.Todos.Remove(todoItem);
            }
        }
    }
}
