using Make_your_own_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Make_your_own_api
{
    public class TodoService
    {

        public TodoService()
        {
            Todos = new List<TodoApiModel>();
        }

        public List<TodoApiModel> Todos { get; private set; }
    }
}
