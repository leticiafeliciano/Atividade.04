using System;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva sua data de nascimento:");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int idade = DateTime.Today.Year - data.Year;

                if (DateTime.Today.DayOfYear < data.DayOfYear)
                {
                    idade = idade - 1;

                    Console.WriteLine($"Você tem {idade} anos!");
                }
                else
                {

                    Console.WriteLine($"Você tem {DateTime.Today.Year - data.Year} anos!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Tente novamente!");
            }
        }
    }
}
