using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MyClass : IOutputProvider, IInputGatherer
    {
        private static List<int> intList = new List<int>();
        private string outputString = "";

        public string GetOutput()
        {
            intList.Reverse();
            foreach (int i in intList)
            {
                outputString = $"{outputString}\n{i}";
            }
            return outputString;
        }

        public void CollectInput(int value)
        {
            intList.Add(value);
        }
    }
}

/*
 * 
 * 
 * 
 */