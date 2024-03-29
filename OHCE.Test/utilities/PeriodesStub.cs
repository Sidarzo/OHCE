﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.utilities
{
    internal class PeriodesStub : IPeriode
    {
        private IPeriode periode => new PeriodeFrancais();
        public string matin => periode.matin;
        public string apresMidi => periode.apresMidi;
        public string soiree => periode.soiree;
        public string nuit => periode.nuit;
    }
}
