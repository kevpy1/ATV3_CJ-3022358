namespace ATV3_CJ_3022358
{

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
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}