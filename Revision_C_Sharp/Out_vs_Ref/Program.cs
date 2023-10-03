namespace Out_vs_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; 
            int b = 2;
            int c = 3;


            ///// By Ref ça va changer la valeur de a /////////////////////
            
            Console.WriteLine("Valeur de a est : {0} avec la modification ", a);
            int result = By_Ref(ref a);
            Console.WriteLine("Valeur de a est {0} après qu'elle est passé en référence ", a);


            ////////////////// By Val il n'y a pas de changement ////////////////////

            Console.WriteLine("Valeur de b avant l'appel de fonction est {0} ", b);
            int result1 = By_Val(b);
            Console.WriteLine("Valeur de b après l'Appel de la fonction est {0} ", b);


            /////////// out comme by ref elle change la variable mais elle besoins d'être initialisé ///////////

            Console.WriteLine("Valeur de c avant l'appel de la fonction est {0} ", c);
            var result2 = By_Out(out c);
            Console.WriteLine("Valeur de la variable c après l'appel à la fonction est : {0} ", c);

        }
        public static int By_Ref(ref int a)
        {
            a += a;
            return a; 
        }
        public static int By_Val(int b)
        {
            b += b;
            return b;
        }

        public static int By_Out(out int num)
        {
            int number = 5;
            num = number;
            return num;
        }
    }
}