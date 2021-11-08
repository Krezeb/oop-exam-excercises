using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public interface IToDo
    {
        public string Text { get; init; }
        public bool IsDone { get; set; }

        public void MarkDone();


    }
}
