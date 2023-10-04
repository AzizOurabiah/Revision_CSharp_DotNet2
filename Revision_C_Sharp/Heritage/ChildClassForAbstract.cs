using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class ChildClassForAbstract :  AbstractClass1
    {
        public override void MethodeAbstract_dans_ClassAbstract1()
        {
            throw new NotImplementedException();
        }
    }
}
