﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    interface ICollectTodos
    {
        public List<Todo> ListTodos(bool isDone);
    }
}
