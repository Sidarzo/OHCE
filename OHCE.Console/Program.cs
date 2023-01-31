using OHCE;
using OHCE.Test;
using OHCE.Test.utilities.Builder;
using System.Globalization;

ILangue langueSys = new LangueDetect().GetLangueSystem();
string periodeSys = new PeriodeDetect().GetPeriode(langueSys);
string chaine;
var ohce = new OHCEBuilder().withlangue(langueSys).withperiode(periodeSys).build();

Console.WriteLine(ohce.DireBonjour());

Console.WriteLine("");

do
{
    Console.Write("Rentrez un texte : ");
    chaine = Console.ReadLine();

    if (chaine != "")
    {
        Console.WriteLine("");
        Console.WriteLine(ohce.Miroir(chaine));
        Console.WriteLine("");
    }

} while (chaine != "");

Console.WriteLine("");
Console.WriteLine(ohce.DireAuRevoir());