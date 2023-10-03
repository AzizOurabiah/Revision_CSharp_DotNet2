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

            Console.WriteLine("/////////////////////// Example des objets ////////////////////////// ");

            #region Travailler avec les objets
            ///**
            ///Example 1 : By val
            ///Il n'y a pas de changement par ce que la fonction AssignationNouvelObjetByVal elle crée un nouveau objet dans la ram nouvelle référence 
            ///**
            Personne p1 = new Personne(111, "Alain");

            Console.WriteLine("Valeur de Personne  avant l'appel de la fonction id {0},  Nom {1} ", p1.id, p1.nom);


            AssignationNouvelObjetByVal(p1);
            Console.WriteLine("Valeur de Personne   Après   l'appel de la fonction  id {0},  Nom {1} ",p1.id, p1.nom);

            ///**
            ///Example 2 : By val
            ///Il y a des changement par ce que la fonction AssignationNouvelObjetByVal1 
            ///elle garde la même référence de l'objet 
            ///elle modifie les valeur de l'objet crée un nouveau objet 
            ///**

            Console.WriteLine("Valeur de Personne  avant l'appel de la fonction id {0},  Nom {1} ", p1.id, p1.nom);


            AssignationNouvelObjetByVal1(p1);
            Console.WriteLine("Valeur de Personne   Après   l'appel de la fonction  id {0},  Nom {1} ", p1.id, p1.nom);

            ///Note:
            ///Quand on fait avec reférece ça va changer de toute les manière
            ///

            #endregion


        
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

        public static void AssignationNouvelObjetByVal(Personne p1)
        {
            p1 = new Personne(222, "Richard");
            //return p1;
        }

        public static void AssignationNouvelObjetByVal1(Personne p1)
        {
            //p1 = new Personne(222, "Richard");
            p1.id = 222;
            p1.nom = "Richard";
            //return p1;
        }
    }  
}