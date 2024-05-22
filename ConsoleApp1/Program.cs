using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples em C#");
                Console.WriteLine("-------------------------");

                // Ler o primeiro número
                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Ler a operação
                Console.Write("Digite a operação (+, -, *, /): ");
                char operacao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // Ler o segundo número
                Console.Write("Digite o segundo número: ");
                
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Calcular o resultado
                double resultado = 0;
                bool operacaoValida = true;

                switch (operacao)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            operacaoValida = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Erro: Operação inválida.");
                        operacaoValida = false;
                        break;
                }

                // Mostrar o resultado
                if (operacaoValida)
                {
                    Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");
                }

                // Perguntar se o usuário deseja realizar outra operação
                Console.Write("Deseja realizar outra operação? (s/n): ");
                char continuar = Console.ReadKey().KeyChar;
                if (continuar != 's' && continuar != 'S')
                {
                    break;
                }
            }

            Console.WriteLine("\nObrigado por usar a calculadora!");
        }
    }
}
