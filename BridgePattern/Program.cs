// See https://aka.ms/new-console-template for more information
using BridgePattern.Bridge.Abstracctions;

namespace BridgePattern
{

    class program
    {






        static void Main(string[] arg)
        {

            ReFindAbstraction abstraction = new ReFindAbstraction();
            abstraction.Function();

            Console.WriteLine("Hello, World!");

        }
    }
}