using OHCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCETest
{
    public class OhceTest
    {
        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS celle-ci est renvoyée en miroir")]
        public void TestMiroir() {

            // QUAND on saisait une chaine
            string result = Ohce.Palindrome("toto");

            //ALORS celle ci est renvoyée en miroir
            Assert.Contains("otot",result);
        }
        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS celle-ci est renvoyée en miroir ET bien dit est envoyé")]
        public void TestPalindrome() {


            // QUAND on saisait une chaine
            string result = Ohce.Palindrome("radar");

            //ALORS celle ci est renvoyée en miroir
            Assert.Contains("radar",result);
            // Et Bien dit ...
            Assert.EndsWith("Bien dit!",result);
        }
        [Fact(DisplayName = "QUAND on saisit une chaîne ALORS «Bonjour» est envoyé avant toute réponse")]
        public void TestBonjour() {

            // QUAND on saisait une chaine
            string result = Ohce.Palindrome("radar");

            //ALORS celle ci est renvoyée en miroir
            Assert.StartsWith("Bonjour!",result);
        }
    }
}
