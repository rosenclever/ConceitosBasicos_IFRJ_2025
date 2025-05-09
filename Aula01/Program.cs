// See https://aka.ms/new-console-template for more information
using Aula01._1bim;
using System.Runtime.InteropServices;

int opcao = 0;
bool continuar = true;
while (continuar)
{
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar dois numeros");
    Console.WriteLine("2 - Converter metros para milímetros");
    Console.WriteLine("Informe a opção desejada: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Conversor();
            break;
        case 0:
            continuar = false;
            break;
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}

void Soma()
{
    int num1, num2;
    Console.WriteLine("Informe o primeiro número");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número");
    num2 = int.Parse(Console.ReadLine());
    SomaDoisNumeros somador = new SomaDoisNumeros();
    int resultado = somador.Somar(num1, num2);
    Console.WriteLine($"A soma dos números {num1} e {num2} é {resultado}");
}

void Conversor()
{
    MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
    Console.WriteLine("Informe o valor em metros: ");
    int metros = int.Parse(Console.ReadLine());
    Console.WriteLine($"O valor {metros}m corresponde a {metrosMilimetros.Converter(metros)} ");

}

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
