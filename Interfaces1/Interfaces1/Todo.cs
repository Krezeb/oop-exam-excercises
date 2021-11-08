using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Todo : IToDo
    {
        public string Text { get; init; }
        public bool IsDone { get; set; } = false;

        public void MarkDone()
        {
            IsDone = true;
        }
    }
}
