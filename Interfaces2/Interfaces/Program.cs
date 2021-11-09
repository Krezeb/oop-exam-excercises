using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputGatherer gatherer = new MyClass(); // Replace 'null' with your class
            IOutputProvider provider = new MyClass(); // Replace 'null' with your class

            InputProcessor inputProcesser = new InputProcessor(gatherer);
            OutputWriter outputWriter = new OutputWriter(provider);

            inputProcesser.GatherData();
            outputWriter.PrintOutput();
        }
    }
}
