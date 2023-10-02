using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class ChildClass1 : BaseClass
    {
        public override void MethodeVirtuel_BaseClass()
        {
            //base.MethodeVirtuel_BaseClass();

            Console.WriteLine("Je suis la méthode ovirride dans la classe Child1 ");
        }

        public void MethodeOridinaire_ChildClass()
        {
            Console.WriteLine("Je suis une méthode oridinaire ChildClass !");
        }
    }
}
