using System;

namespace ExceptionTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere um numero inteiro: ");
            
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
