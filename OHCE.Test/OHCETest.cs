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
    }

}