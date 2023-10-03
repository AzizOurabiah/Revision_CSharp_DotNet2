namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();

            ChildClass1 cc = new ChildClass1();

            cc.MethodeVirtuel_BaseClass();

            cc.MethodeNotVirtual_BaseClass();

            BaseClass bc2 = new ChildClass1();

            bc2.MethodeNotVirtual_BaseClass();
            bc2.MethodeVirtuel_BaseClass();

            bc.MethodeNotVirtual_BaseClass();
            bc.MethodeVirtuel_BaseClass();

            ChildClass1 cc1 = (ChildClass1) new BaseClass();
        }
    }
}