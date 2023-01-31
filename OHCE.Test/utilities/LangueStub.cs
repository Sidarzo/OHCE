namespace OHCE.Test.utilities
{
    internal class LangueStub : ILangue
    {
        private ILangue langue => new LangueFrancais();
        public string BienDit => langue.BienDit;
        public string Bonjour => langue.Bonjour;

    }
}
