using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test
{
    public class LangueDetect
    {
        public ILangue GetLangueSystem()
        {
            string systemLangue = CultureInfo.CurrentCulture.Name;

            if(systemLangue == "fr-FR"){
                return new LangueFrancais();
            }
            else if (systemLangue == "en_EN")
            {
                return new LangueAnglais();

            }

            return new LangueFrancais();
        }
    }
}
