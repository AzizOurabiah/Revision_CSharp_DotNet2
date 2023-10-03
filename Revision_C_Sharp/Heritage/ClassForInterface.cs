using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class ClassForInterface : Interface1, Interface2
    {
        public void MethodeInterfac2()
        {
            throw new NotImplementedException();
        }

        void Interface1.MethodeInterfac1()
        {
            throw new NotImplementedException();
        }
    }
}
