namespace OHCE.Test.utilities
{
    internal class LangueStub : ILangue
    {
        public string BienDit => new LangueFrancais().BienDit;
    }
}
