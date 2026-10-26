using System;

namespace ExceptionTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere um numero inteiro: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero inserido: {i}");
        }
    }
}
