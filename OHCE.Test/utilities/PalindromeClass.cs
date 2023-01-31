﻿using System;
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
            yield return new object[] { new LangueFrancais(), "laval" };
            yield return new object[] { new LangueAnglais(), "kayak" };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
