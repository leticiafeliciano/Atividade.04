using System;

namespace Atividade02
{
    internal class Program
    {
        private const string _sim = "SIM";

        static void Main(string[] args)
        {
            string continuar = string.Empty;
            decimal valorUm = 0.0m;
            decimal valorDois = 0.0m;

            try
            {
                do
                {
                    Console.WriteLine("Informe a operação matematica" + "que deseja efetuar (+, -, *, /, %): ");

                    char operacao = char.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            Console.WriteLine("Informe o primeiro valor para a soma:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor  para a soma: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da Adição é : {valorUm + valorDois} ");
                            break;
                        case '-':
                            Console.WriteLine("Informe o primeiro valor para a subtração:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor  para a subtração: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da subtração é : {valorUm - valorDois} ");
                            break;
                        case '*':
                            Console.WriteLine("Informe o primeiro valor para a multiplicação:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor  para a multiplicação: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da multiplicação é : {valorUm * valorDois} ");
                            break;
                        case '/':
                            Console.WriteLine("Informe o primeiro valor para a divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor  para a divisão: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da divisão é : {valorUm / valorDois} ");
                            break;
                        case '%':
                            Console.WriteLine("Informe o primeiro valor para o resto da divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o segundo valor  para o resto da divisão: ");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado do resto da divisão é :{valorUm % valorDois} ");
                            break;
                        default:
                            throw new Exception("Operação ,atematica não" + "configurada!!! Verifique");
                    }
                    Console.WriteLine("Deseja continuar? [sim/não]");
                    continuar = Console.ReadLine();

                } while (_sim.Equals(continuar.ToUpper()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}





