using System.Text.RegularExpressions;

var caracteres = "";

while (!caracteres.Equals("n"))
{
    Console.Write("Informe um valor:  ");
    caracteres = Console.ReadLine();
    bool ok = Regex.IsMatch(caracteres, "^[0-9]{3}[.]?[0-9]{3}[.]?[0-9]{3}[-]?[0-9]{2}$");

    if (!ok)
        Console.WriteLine("False.");
    else
        Console.WriteLine("True.");
}
