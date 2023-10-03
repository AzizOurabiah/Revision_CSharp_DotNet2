using System.Reflection;
using System;

namespace ComparaisonDesVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CompareTo par type valeur
            ///***
            ///La fonction CompareTo elle compare les objet d'abord
            ///Si les objets sont de type différent elle retourner
            /// ///
            /// 
            int a = 5;
            long b = 5;

            try
            {
                if(a.CompareTo(b) == 5)
                    Console.WriteLine("Les deux valeur de type différent sont identique !");
            }catch(Exception e) 
            {
                Console.WriteLine("Les deux valeurs de type différent ne sont pas identique. L'erreur est : " + e.Message);
            }
            #endregion

            #region Equal de type valeur
            ///***
            ///Type référence : Par défaut, la méthode Equals effectue une comparaison des
            ///références des objets.Si on a deux références qui pointent à des zones mémoires
            ///différentes, le résultat retourne faux même si le contenu des objets est pareil.
            ///



            if (a.Equals(b))
                Console.WriteLine("Integer peut être convertit dans long");
            Console.WriteLine("Integer ne peut pas être convertit en long");

            if(b.Equals(a))
                Console.WriteLine("Long peut être convertit en Int");
            Console.WriteLine("Long ne peut pas être convertit en Int");
            #endregion

            #region Equal de type objet
            ///***
            ///Type référence : Par défaut, la méthode Equals effectue une comparaison des
            ///références des objets.Si on a deux références qui pointent à des zones mémoires
            ///différentes, le résultat retourne faux même si le contenu des objets est pareil.
            ///

            Mail mail1 = new Mail(1, "msg");
            Mail mail2 = new Mail(2, "msg");

            if(mail1.Equals(mail2))
                Console.WriteLine("mail1 et mail2 sont équal !");
            Console.WriteLine("mail1 et mail2 ne sont pas identique !");


            Mail mail3 = new Mail(3, "msg3");
            Mail mail4 = mail3;

            if (mail3.Equals(mail4))
            {
                Console.WriteLine("mail 3 équal mail 4");
            }
            else
            {
                Console.WriteLine("mail 3 not équal mail 4");
            }
            #endregion
        }
    }
    public class Mail
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Mail(int id, string message) 
        {
            Id = id;
            Message = message;        
        }
    }
}