// See https://aka.ms/new-console-template for more information
using BridgePattern.Bridge.Abstracctions;
using BridgePattern.MailService.MailServiceAbstraction;
using BridgePattern.NewFolder;

namespace BridgePattern
{

    class program
    {






        static void Main(string[] arg)
        {
            ///First test
            //ReFindAbstraction abstraction = new ReFindAbstraction();
            //abstraction.Function();

            //Console.WriteLine("Hello, World!");

            ///secandtest
           
            RefindMailServiceAbstraction mailServiceAbstraction = new RefindMailServiceAbstraction();
            mailServiceAbstraction.send(new emailDTO { Reciver = "saeed", Tilte = "test", teax = "this is test" });
            Console.ReadLine();
        }
    }
}