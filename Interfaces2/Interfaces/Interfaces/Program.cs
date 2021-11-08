using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputGatherer gatherer = null; // Replace 'null' with your class
            IOutputProvider provider = null; // Replace 'null' with your class

            InputProcessor inputProcesser = new InputProcessor(gatherer);
            OutputWriter outputWriter = new OutputWriter(provider);

            inputProcesser.GatherData();
            outputWriter.PrintOutput();
        }
    }
}
