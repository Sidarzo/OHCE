using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities.Builder
{
    public class OHCEBuilder
    {
        private ILangue langue;
        private string periode;

        public OHCEBuilder withlangue(ILangue langue)
        {
            this.langue = langue;
            return this;
        }  
        public OHCEBuilder withperiode(string periode)
        {
            this.periode = periode;
            return this;
        }
        public Ohce build()
        {
            return new Ohce(this.langue, this.periode);
        }


    }
}
