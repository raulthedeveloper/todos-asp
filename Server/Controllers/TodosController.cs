using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.DAL;
using Business.Models;


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
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Todos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
