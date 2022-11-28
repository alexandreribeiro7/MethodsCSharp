// Interpolação de String

string Aluno = "Harry";
string Professor = "Minerva";

string CartaConvite = $" Caro sr/sra {Aluno}\n " +
                      $"Você foi aceito na faculdade de Hogwarts\n " +
                      $"o seu {Professor} te aguarda em sala\n";

Console.WriteLine(CartaConvite);

// Interpolação com Concatenação + Format

string Nome = "Alexandre";
string Sobrenome = "Ribeiro";
var NomeCompleto = Nome + " " + Sobrenome;
var MensagemFormatada = string.Format("Nome Completo: {0}\n", NomeCompleto);
Console.WriteLine(MensagemFormatada);

// Metodo Split

var mensagem = "Vamos, dividir, essse texto, conforme a, virgula";
string[] _split = mensagem.Split(',');

for (int i = 0; i < _split.Length; i++) {
    Console.WriteLine($"{_split[i]}\n");
}

// Metodo Replace()

string frase = @"Exelentíssimo _nomeasubstituir_ 
Estamos a sua espera para a conferência anual de .NET do Vale do Sílicio.";
Console.WriteLine(frase.Replace("_nomeasubstituir_", "Bill Gates"));

// Métodos Substring

string chave_aleatoria = Guid.NewGuid().ToString();
Console.WriteLine("\nIdentificador gerado = " + chave_aleatoria.Substring(0, 16));