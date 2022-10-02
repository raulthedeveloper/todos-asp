using System;
using Business.Models;
using System.Linq;
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

		public Todos AddTodo(Todos t)
		{
			TodosList.Add(t);
			return t;
		}

		public List<Todos> EditTodo(int id, Todos t)
		{
			foreach(var item in TodosList.Where(item => item.Id == id))
			{
				item.Id = t.Id;
				item.Todo = t.Todo;
			}

			return TodosList;
		}
	}
}

