using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public static class Ohce
    {
        public static string Palindrome(string mot)
        {
            string motreverse = new string(mot.Reverse().ToArray());

            if (mot.Equals(motreverse)){
                return $"Bonjour!{motreverse} Bien dit!Au revoir!";
            }
            return $"Bonjour!{motreverse}Au revoir!";


        }
    }
}
