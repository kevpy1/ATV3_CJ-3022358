
//  atividade 1 // 



namespace ATV3_CJ_3022358
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
