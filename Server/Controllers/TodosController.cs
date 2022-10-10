using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.DAL;
using Business.Models;
using System.Text.Json;


namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodosData todosData = new TodosData();

        // GET: api/Todos
        [HttpGet]
        public IEnumerable<Todos> Get()
        {
            return todosData.GetTodos();
        }

        // GET: api/Todos/5
        [HttpGet("{id}", Name = "Get")]
        public Todos Get(int id)
        {
            return todosData.GetTodo(id);
        }

        // POST: api/Todos
        [HttpPost]
        public ActionResult<Todos> Post([FromBody] Todos value)
        {
            string JsonString = JsonSerializer.Serialize(value);
            return Ok(todosData.AddTodo(JsonString));


        }

        // PUT: api/Todos/5
        [HttpPut("{id}")]
        public ActionResult<Todos> Put(int id, [FromBody] Todos value)
        {
            string JsonString = JsonSerializer.Serialize(value);

            return Ok(todosData.EditTodo(id, JsonString));

        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
