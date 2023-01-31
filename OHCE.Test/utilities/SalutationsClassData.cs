using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    internal class SalutationsClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrancais(), new PeriodeFrancais().matin };
            yield return new object[] { new LangueFrancais(), new PeriodeFrancais().apresMidi };
            yield return new object[] { new LangueFrancais(), new PeriodeFrancais().soiree};
            yield return new object[] { new LangueFrancais(), new PeriodeFrancais().nuit};

            yield return new object[] { new LangueAnglais(), new PeriodeAnglais().matin };
            yield return new object[] { new LangueAnglais(), new PeriodeAnglais().apresMidi };
            yield return new object[] { new LangueAnglais(), new PeriodeAnglais().soiree };
            yield return new object[] { new LangueAnglais(), new PeriodeAnglais().nuit };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
