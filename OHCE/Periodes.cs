using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class PeriodeFrancais : IPeriode
    {
        public string matin => "matin";
        public string apresMidi => "après-midi";
        public string soiree => "soirée";
        public string nuit => "nuit";
    }  
    public class PeriodeAnglais : IPeriode
    {
        public string matin => "morning";
        public string apresMidi => "afternoon";
        public string soiree => "evening";
        public string nuit => "night";
    }
}
