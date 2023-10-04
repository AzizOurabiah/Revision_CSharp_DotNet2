namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();

            ChildClass1ForBaseClasse cc = new ChildClass1ForBaseClasse();

            cc.MethodeVirtuel_BaseClass();

            cc.MethodeNotVirtual_BaseClass();

            BaseClass bc2 = new ChildClass1ForBaseClasse();

            bc2.MethodeNotVirtual_BaseClass();
            bc2.MethodeVirtuel_BaseClass();

            bc.MethodeNotVirtual_BaseClass();
            bc.MethodeVirtuel_BaseClass();

            ChildClass1ForBaseClasse cc1 = (ChildClass1ForBaseClasse) new BaseClass();
        }
    }
}