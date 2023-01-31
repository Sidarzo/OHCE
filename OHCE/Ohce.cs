
using System.Text;

namespace OHCE
{
    public class Ohce
    {
        public ILangue langue;
        public Ohce(ILangue langue)
        {
            this.langue = langue;
        }
    
        public string Traitement(string mot) {
            var builderString = new StringBuilder();
            var miroir = new string(mot.Reverse().ToArray());

            builderString.Append(langue.Bonjour);

            builderString.Append(miroir);

            if(miroir == mot) { builderString.Append(langue.BienDit); };

            builderString.Append(langue.AuRevoir);
            return builderString.ToString();
        }
    }
}