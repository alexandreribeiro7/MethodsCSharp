using System.Text.RegularExpressions;

Console.Write("Informe um cpf para validação: ");
var cpf = Console.ReadLine();

Regex regex = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnorePatternWhitespace);
if (regex.IsMatch(cpf))
{
    Console.WriteLine("CPF válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}