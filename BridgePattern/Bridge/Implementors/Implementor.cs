using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge.Implementors
{
    public abstract class Implementor
    {
        public abstract void Implementation();
    }
    public class ConcreateImolementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("ConcreateImolementorClass");
        }
    }
}
