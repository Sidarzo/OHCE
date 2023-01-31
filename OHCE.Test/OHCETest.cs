using OHCE.Test.utilities;

namespace OHCE.Test
{
    public class OHCETest
    {
        [Fact(DisplayName = "QUAND un mot est rentré ALORS on obtient son miroir")]
        public void TestMiroir()
        {
            var resultat = new Ohce(new LangueStub()).Traitement("laval");
            Assert.Contains("laval", resultat);
        }

        [Fact(DisplayName ="QUAND un mot est rentré ALORS on obtient son palindrome ET bien dit ! est envoyé")]
        public void TestPalindrome()
        {
            const string palindrome = "kayak";

            // QUAND un mot est rentrer
            var resultat = new Ohce(new LangueStub()).Traitement(palindrome);

            // ALORS on obtient son palindrome*
            Assert.Contains(palindrome, resultat);

            var indexPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endPalindrome = indexPalindrome + palindrome.Length;
            resultat = resultat[endPalindrome..];

            // ET bien dit ! est envoyé
            Assert.Contains("Bien dit !", resultat);

        }

        [Fact(DisplayName ="QUAND un mot est rentré ALORS Bonjour est envoyé avant toute chose")]
        public void TestBonjour()
        {
            var resultat = new Ohce(new LangueStub()).Traitement("Le TDD c'est super !");
            Assert.StartsWith("Bonjour", resultat);
        }

        [Fact(DisplayName ="QUAND un mot est rentré ALORS Au revoir est envoyé en dernier" )]
        public void TestAuRevoir()
        {
            // QUAND un mot est rentré 
            var resultat = new Ohce(new LangueStub()).Traitement("Super le TDD !!");
            //ALORS Au revoir est envoyé en dernier
            Assert.EndsWith("Au revoir", resultat);
        }

        [Theory(DisplayName ="ETANT DONNE un utilisateur parlant une langue QUAND on dit un palindrome ALORS il est renvoyé bien dit ET dans sa langue")]
        [ClassData(typeof(PalindromeClass))]
        public void TestPalindromeLangue(ILangue langue, string palindrome, string biendit)
        {
            // ETANT DONNE un utilisateur parlant une langue QUAND on dit un palindrome
            var resultat = new Ohce(langue).Traitement(palindrome);

            //ALORS il est renvoyé bien dit
            Assert.Contains(palindrome, resultat);


            var indexPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endPalindrome = indexPalindrome + palindrome.Length;
            resultat = resultat[endPalindrome..];

            // ET bien dit ! est envoyé dans sa langue
            Assert.Contains(biendit, resultat);
        }
    }

}