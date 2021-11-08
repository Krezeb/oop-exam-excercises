using System;

namespace Exam
{
    class Conditions
    {
        private int i1;
        private int i2;
        private int i3;
        private bool b1;
        private bool b2;
        private string s1;
        private string s2;

        public void Condition()
        {
            bool a = (i1 >= 30);                // Replace 'false' with your solution
            bool b = (i1 < 0 && i2 > 100);      // Replace 'false' with your solution
            bool c = (b1 == true || b2 == true);// Replace 'false' with your solution
            bool d = (s1 == null);              // Replace 'false' with your solution
            bool e = ((i1 < 20 && i1 > 10) || i3 == 100); // Replace 'false' with your solution
            bool f = ((s1 == null || s2 == null) && i3 >= 200); // Replace 'false' with your solution

            //Debug
            Console.WriteLine($"a is {a}");
            Console.WriteLine($"b is {b}");
            Console.WriteLine($"c is {c}");
            Console.WriteLine($"d is {d}");
            Console.WriteLine($"e is {e}");
            Console.WriteLine($"f is {f}");
        }
    }
}
