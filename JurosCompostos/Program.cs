using System;

namespace JurosCompostos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha o que deseja calcular: ");
                Console.WriteLine("1 - Montante");
                Console.WriteLine("2 - Capital");
                Console.WriteLine("3 - Juros");
                Console.WriteLine("4 - Taxa de Juros");
                Console.WriteLine("5 - Periodo");
                Console.WriteLine("6 - Sair");
                Console.Write("Opcao: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CalcularMontante();
                        break;
                    case 2:
                        CalcularCapital();
                        break;
                    case 3:
                        CalcularJuros();
                        break;
                    case 4:
                        CalcularTaxa();
                        break;
                    case 5:
                        CalcularPeriodo();
                        break;
                    case 6:
                        Console.WriteLine("Saindo do Programa");
                        return;
                    default:
                        Console.WriteLine("Opcao Invalida. Tente Novamente...");
                        break;
                }
                   
            }
        }

        static void CalcularMontante()
        {

        }

        static void CalcularCapital()
        {

        }

        static void CalcularJuros()
        {

        }

        static void CalcularTaxa()
        {

        }

        static void CalcularPeriodo()
        {

        }
    }
}
