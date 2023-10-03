using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Out_vs_Ref
{
    internal class Personne
    {
        private int _Id { get; set; }
        private string _Nom { get; set; }
        public int id 
        { 
            get { return _Id; }         
            set { _Id = value; }               
        }

        public string nom 
        { 
            get { return _Nom; } 
            set { _Nom = value; } 
        }

        public Personne(int id, string nom)
        {
            _Id = id;
            _Nom = nom;
            
        }
    }
}
