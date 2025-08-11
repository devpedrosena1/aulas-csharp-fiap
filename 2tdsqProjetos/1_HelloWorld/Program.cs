// See https://aka.ms/new-console-template for more information

// formas de escrever algo na tela

using System.Diagnostics;

Console.WriteLine("Hello, World!");
Console.WriteLine("This is my first class of C#");

Console.WriteLine("""
                  Hello,
                  World
                  !
                  """);

// formas de ler, bem parecido com o Scanner do Java
string text = Console.ReadLine();
Console.WriteLine(text);

// Variáveis

// Podemos utilizar o 'var' para declarar o tipo da variável, isso faria os '...' sumir.

int newAge = 20;
var newAgeTwo = 20; // 'var' consegue entender que o tipo da variável é int

// (int, short and long)
// A diferença dos tipos é o tamanho de memória que cada um ocupa
int year = 2005;
short age = 19;
long bigNumber = 123456789;

// (float, double and decimal)
float height = 1.83f; // devemos usar um 'f' para indicar que é um float
double peso = 70.5d; // utilizamos o 'd' para indicar que é um double. É o padrão
decimal alturaDecimal = 5.5m; // utilizamos o 'm' para indicar que é um decimal

// (string, char) 
char letter = 'A';
string s = "Hello, World"; // No C# o tipo string é um tipo PRIMITIVO, além de ser uma classe

// (boolean)
bool condicao = true;

// (condicionais)
Console.WriteLine(letter == 'A' ? "A letra é A" : "A letra é diferente de A");

switch (letter)
{
    case 'A':
        Console.WriteLine("A letra é A");
        break;
    case 'B':
        Console.WriteLine("A letra é B");
        break;
    default:
        Console.WriteLine("A letra não é nem A e nem B");
        break;
}

var ano = int.Parse(Console.ReadLine());
//
// var numeroCalculado:int = ano switch
// {
//     < 2000 => 2000,
//     >= 2000 => DateTime.Now.Year
// };

// estruturas de repetição
for (var i = 0; i < 10; i++)
    Console.WriteLine(i);
    
foreach (var i in new int[] {1,2,3,4,5,6,7,8,9})
    Console.WriteLine(i);

while (ano < 2024)
{
    Console.Write(ano);
    ano++;
}   