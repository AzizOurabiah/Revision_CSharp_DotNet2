using System.Collections.Generic;

namespace Dictionnairy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of strings, with string keys,
            // and access it through the IDictionary generic interface.
            IDictionary<string, string> openWith = new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");

            }catch(Exception e)
            {
                Console.WriteLine("Un element with the key \"txt\" already exist ! " + e.Message );
            }

            Console.WriteLine($"Lir une données de dictionnaire {openWith["txt"]}");
            Console.WriteLine("Lir une données de dictionnaire {0}", openWith["txt"]);


            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            Console.WriteLine("Valeur de la clé ajouté est : {0}", openWith["doc"]);

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            foreach(KeyValuePair<string, string> keyValue in openWith)
            {
                Console.WriteLine("Key is : {0} ,      value is : {1}", keyValue.Key, keyValue.Value);
            }

            Console.WriteLine("Remove key value from the Dictionnairy !");


            // Use the Remove method to remove a key/value pair.
            openWith.Remove("doc");

            if(!openWith.ContainsKey("doc"))
                Console.WriteLine("Key \"doc\" is not found");



        }
    }
}