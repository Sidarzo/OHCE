using OHCE.Test.utilities;
using OHCE.Test.utilities.Builder;

namespace OHCE.Test
{
    public class OHCETest
    {
        [Fact(DisplayName = "QUAND un mot est rentré ALORS on obtient son miroir")]
        public void TestMiroir()
        {
            var resultat = new OHCEBuilder().withlangue(new LangueStub()).build().Traitement("laval");
            Assert.Contains("laval", resultat);
        }

        [Fact(DisplayName ="QUAND un mot est rentré ALORS on obtient son palindrome ET bien dit ! est envoyé")]
        public void TestPalindrome()
        {
            const string palindrome = "kayak";

            // QUAND un mot est rentrer
            var resultat = new OHCEBuilder().withlangue(new LangueStub()).build().Traitement(palindrome);

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
            var resultat = new OHCEBuilder().withlangue(new LangueStub()).build().Traitement("Le TDD c'est super !");
            Assert.StartsWith("Bonjour", resultat);
        }

        [Fact(DisplayName ="QUAND un mot est rentré ALORS Au revoir est envoyé en dernier" )]
        public void TestAuRevoir()
        {
            // QUAND un mot est rentré 
            var resultat = new OHCEBuilder().withlangue(new LangueStub()).build().Traitement("Super le TDD !!");
            //ALORS Au revoir est envoyé en dernier
            Assert.EndsWith("Au revoir", resultat);
        }

        [Theory(DisplayName ="ETANT DONNE un utilisateur parlant une langue QUAND on dit un palindrome ALORS il est renvoyé bien dit ET dans sa langue")]
        [ClassData(typeof(PalindromeClass))]
        public void TestPalindromeLangue(ILangue langue, string palindrome)
        {
            // ETANT DONNE un utilisateur parlant une langue QUAND on dit un palindrome
            var resultat = new OHCEBuilder().withlangue(langue).build().Traitement(palindrome);

            //ALORS il est renvoyé bien dit
            Assert.Contains(palindrome, resultat);


            var indexPalindrome = resultat.IndexOf(palindrome, StringComparison.Ordinal);
            var endPalindrome = indexPalindrome + palindrome.Length;
            resultat = resultat[endPalindrome..];

            // ET bien dit ! est envoyé dans sa langue
            Assert.Contains(langue.BienDit, resultat);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on dit un mot ALORS il est renvoyé bonjour ET dans sa langue")]
        [ClassData(typeof(SalutationsClassData))]
        public void TestBonjourLangue(ILangue langue)
        {
            //ETANT DONNE un utilisateur parlant une langue QUAND on dit un mot 
            var resultat = new OHCEBuilder().withlangue(langue).build().Traitement("Le tdd !!");

            // ALORS il est renvoyé bonjour ET dans sa langue

            Assert.StartsWith(langue.Bonjour, resultat);

        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue QUAND on dit un mot ALORS il est renvoyé auRevoir ET dans sa langue")]
        [ClassData(typeof(SalutationsClassData))]
        public void TestAuRevoirLangue(ILangue langue)
        {
            //ETANT DONNE un utilisateur parlant une langue QUAND on dit un mot 
            var resultat = new OHCEBuilder().withlangue(langue).build().Traitement("Le tdd !!");

            // ALORS il est renvoyé au revoir ET dans sa langue

            Assert.EndsWith(langue.AuRevoir, resultat);

        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue ET que la période de la journée est <période> QUAND on saisit une chaîne ALORS <salutation> de cette langue à cette période est envoyé avant tout")]
        [ClassData(typeof(SalutationsPeriodeClassData))]
        public void TestBonjourLanguePeriode(ILangue langue, string periode)
        {
            //QUAND on saisit une chaîne
            var resultat = new OHCEBuilder().withlangue(langue).withperiode(periode).build().Traitement("test de chaine");

            //ALORS <bonjour> de cette langue à cette période est envoyé avant tout
            Assert.StartsWith(langue.Bonjour + periode, resultat);
        }


    }

}