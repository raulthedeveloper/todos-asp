using System;
using Business.Models;
using System.Linq;
using System.Text.Json;


namespace Business.DAL
{
    public class TodosData
    {
        private List<Todos> TodosList = new List<Todos>
            {
                new Todos
                {
                    Id = 0,
                    Todo = "Go shopping"
                },
                new Todos
                {
                    Id = 1,
                    Todo = "Check the mail"
                },
                new Todos
                {
                    Id = 2,
                    Todo = "Call car rental place"
                }
            };



            public List<Todos> GetTodos()
            {
                return TodosList;
            }

            public Todos GetTodo(int Id)
            {

                return TodosList.First(e => e.Id == Id);
            }

           

            public List<Todos> EditTodo(int id, string t)
            {
                
                Todos todos = JsonSerializer.Deserialize<Todos>(t);

                foreach (var item in TodosList.Where(item => item.Id == id))
                {
                    item.Id = todos.Id;
                    item.Todo = todos.Todo;
                }

                 return TodosList;
            }

            public List<Todos> AddTodo(string t)
            {
                Todos todo = JsonSerializer.Deserialize<Todos>(t);
                TodosList.Add(todo);
                return TodosList;
            }
        }
}

