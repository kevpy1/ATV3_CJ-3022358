using System;

namespace ATV-CJ3022358
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua nota:");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 6)
        {
            Console.WriteLine("Aprovado");

        }
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
 
//ATIVIDADE 3

{
    static void Main(string[] args)
{
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);
    int tentativasRestantes = 3;

    Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
    Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

    while (tentativasRestantes > 0)
    {
        Console.Write("Digite um número: ");
        if (int.TryParse(Console.ReadLine(), out int palpite))
        {
            if (palpite == numeroAleatorio)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                return;
            }

            Console.WriteLine(palpite < numeroAleatorio
                ? "O número pensado é maior que o seu palpite."
                : "O número pensado é menor que o seu palpite.");

        }
    }
}
}// atividade 1
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}

//atividade 2

Console.Write("Digite o comprimento do primeiro lado: ");
int lado1 = int.Parse(Console.ReadLine());

Console.Write("Digite o comprimento do segundo lado: ");
int lado2 = int.Parse(Console.ReadLine());

Console.Write("Digite o comprimento do terceiro lado: ");
int lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é isósceles.");
}
else
{
    Console.WriteLine("O triângulo é escaleno.");
}

//atvidade 4

Console.Write("Digite o nome de usuário: ");
string nomeUsuario = Console.ReadLine();

Console.Write("Digite a senha: ");
string senha = Console.ReadLine();

if (nomeUsuario == "admin" && senha == "admin123")
{
    Console.WriteLine("Acesso concedido.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

//atividades 5

Console.Write("Digite a nota: ");
int nota = int.Parse(Console.ReadLine());

string conceito;

if (nota >= 90 && nota <= 100)
{
    conceito = "A";
}
else if (nota >= 80 && nota < 90)
{
    conceito = "B";
}
else if (nota >= 70 && nota < 80)
{
    conceito = "C";
}
else if (nota >= 60 && nota < 70)
{
    conceito = "D";
}
else
{
    conceito = "F";
}

Console.WriteLine("Conceito: " + conceito);

//atividade 6
string[] opcoes = { "Pedra", "Papel", "Tesoura" };

Console.Write("Escolha: Pedra (0), Papel (1) ou Tesoura (2): ");
int escolhaUsuario = int.Parse(Console.ReadLine());

if (escolhaUsuario < 0 || escolhaUsuario > 2)
{
    Console.WriteLine("Escolha inválida.");
    return;
}

int escolhaComputador = random.Next(0, 3);

Console.WriteLine("Você escolheu: " + opcoes[escolhaUsuario]);
Console.WriteLine("O computador escolheu: " + opcoes[escolhaComputador]);

if (escolhaUsuario == escolhaComputador)
{
    Console.WriteLine("Empate!");
}
else if ((escolhaUsuario == 0 && escolhaComputador == 2) ||
         (escolhaUsuario == 1 && escolhaComputador == 0) ||
         (escolhaUsuario == 2 && escolhaComputador == 1))
{
    Console.WriteLine("Você ganhou!");
}
else
{
    Console.WriteLine("O computador ganhou!");
}

