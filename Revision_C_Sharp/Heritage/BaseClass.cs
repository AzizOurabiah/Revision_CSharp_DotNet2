using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class BaseClass
    {
        public virtual void MethodeVirtuel_BaseClass()
        {
            Console.WriteLine("Je suis la méthode Virtuel de la class de base ");
        }

        public void MethodeNotVirtual_BaseClass()
        {
            Console.WriteLine("Je suis la méthode not virtual de la class de base ");
        }
    }
}
