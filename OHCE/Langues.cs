using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    
        public class LangueFrancais : ILangue
        {
            public string BienDit => "Bien dit !";
             public string Bonjour => "Bonjour";
            public string AuRevoir => "Au revoir";
        }

        public class LangueAnglais : ILangue
        {
            public string BienDit => "Well said !";
            public string Bonjour => "Hello";
            public string AuRevoir => "Goodbye";

    }

}
