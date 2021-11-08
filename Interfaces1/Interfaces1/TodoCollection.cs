using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class TodoCollection : ITodoCollection
    {
        private List<Todo> _todos;

        public TodoCollection()
        {
            _todos = new List<Todo>();
        }

        public void CreateTodo(string text)
        {
            Todo todo = new Todo()
            {
                Text = text
            };
            _todos.Add(todo);
        }

        public List<IToDo> ListTodos(bool isDone)
        {
            List<IToDo> result = new List<IToDo>();
            foreach (Todo todo in _todos)
            {
                if (todo.IsDone == isDone)
                {
                    result.Add(todo);
                }
            }
            return result;
        }
    }
}
