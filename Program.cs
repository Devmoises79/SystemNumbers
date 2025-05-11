using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Menu de Números ===");
            Console.WriteLine("1 - Adicionar um número");
            Console.WriteLine("2 - Ver estatísticas");
            Console.WriteLine("3 - Limpar dados");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");

            bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!entradaValida)
            {
                Console.WriteLine("Entrada inválida. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um número: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        numeros.Add(numero);
                        Console.WriteLine("Número adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 2:
                    if (numeros.Count > 0)
                    {
                        Console.WriteLine($"Maior número: {numeros.Max()}");
                        Console.WriteLine($"Menor número: {numeros.Min()}");
                        Console.WriteLine($"Média dos números: {numeros.Average():F2}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum número registrado.");
                    }
                    break;

                case 3:
                    numeros.Clear();
                    Console.WriteLine("Dados limpos com sucesso!");
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 4);
    }
}
