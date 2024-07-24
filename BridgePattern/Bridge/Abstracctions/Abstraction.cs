using BridgePattern.Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge.Abstracctions
{
    public abstract class Abstraction
    {


        private Implementor implementor;
        protected Abstraction()
        {
                implementor=new ConcreateImolementor();
        }
        // private Implementors =new   Implementors
        public virtual void Function() 
        {
            implementor.Implementation();
        }
    }

    public class ReFindAbstraction: Abstraction
    {

    }
}
