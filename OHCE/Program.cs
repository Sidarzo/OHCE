using System.Globalization;

Console.WriteLine("Hello, World!");

DateTime dateNow = DateTime.Now;

CultureInfo ci = CultureInfo.InstalledUICulture;

if (dateNow.Hour >= 22 || dateNow.Hour < 6)
{
    // Evening*
    Console.WriteLine(ci.Name == "fr-FR" ? "Bonsoir!" : "Good evening");
     
}
else
{
    Console.WriteLine(ci.Name == "fr-FR" ? "Bonjour!" : "Hello!!!!!!!");
}

Console.WriteLine("Saisir pour avoir le mot miroir");

string stringToReverse = Console.ReadLine().ToLower();
char[] charArray = stringToReverse.ToCharArray();
Array.Reverse(charArray);
string stringReverse = new string(charArray);

Console.WriteLine(stringReverse);

Console.WriteLine("----------");

Console.WriteLine("Saisissez un mot pour vérifier si c'est un palindrome");

string stringToVerif = Console.ReadLine().ToLower();
char[] charArrayPalin = stringToVerif.ToCharArray();
Array.Reverse(charArrayPalin);
string stringVerifReverse = new string(charArrayPalin);

if (stringToVerif.Equals(stringVerifReverse))
{
    Console.WriteLine(stringVerifReverse);
    Console.WriteLine("Bien dit!");
}
else
{
    Console.WriteLine($"{stringToVerif} n'est pas un palindrome il donne {stringVerifReverse}");
}
