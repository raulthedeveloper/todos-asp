using System;
using Business.Models;

namespace Server.DAL
{
	public class TodosTestData
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
    }
}

