
using System.Text;

namespace OHCE
{
    public class Ohce
    {
        public string Traitement(string mot) {
            var builderString = new StringBuilder();
            var miroir = new string(mot.Reverse().ToArray());

            builderString.Append(miroir);

            if(miroir == mot) { builderString.Append("Bien dit !"); };
            return builderString.ToString();
        }
    }
}