using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
                if (myArray[i] % 3 == 0 && myArray[i] % 5 == 0)
                    myArray[i] = myArray[i] * myArray[i - 1] + 15;
                else if (myArray[i] %3 == 0)
                    myArray[i] = myArray[i] * myArray[i-1];
                else if (myArray[i] %5 == 0)
                    myArray[i] = myArray[i] + 15;
            }
        }
    }
}
