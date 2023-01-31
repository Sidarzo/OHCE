using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    public class PalindromeClass : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new LangueFrancais(), "laval", new LangueFrancais().BienDit };
            yield return new object[] { new LangueAnglais(), "kayak", new LangueAnglais().BienDit };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
