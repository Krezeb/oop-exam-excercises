using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public interface ITodoCollection
    {

        public void CreateTodo(string text);


        public List<IToDo> ListTodos(bool isDone);
    }

}

