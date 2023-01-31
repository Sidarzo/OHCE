namespace OHCE.Test
{
    public class OHCETest
    {
        [Fact(DisplayName = "QUAND un mot est rentrer ALORS on obtient son miroir")]
        public void TestMiroir()
        {
            var resultat = new Ohce().Traitement("laval");
            Assert.Contains("laval", resultat);
        }

        [Fact(DisplayName ="QUAND un mot est rentrer ALORS on obtient son palindrome ET bien dit ! est envoyé")]
        public void TestPalindrome()
        {
            const string palindrome = "kayak";

            // QUAND un mot est rentrer
            var resultat = new Ohce().Traitement(palindrome);

            // ALORS on obtient son palindrome*
            Assert.Contains(palindrome, resultat);

            var indexPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endPalindrome = indexPalindrome + palindrome.Length;
            resultat = resultat[endPalindrome..];

            // ET bien dit ! est envoyé
            Assert.Contains("Bien dit !", resultat);

        }
    }

}