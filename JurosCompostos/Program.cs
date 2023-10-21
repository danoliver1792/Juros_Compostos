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
                        CalcularTaxa();
                        break;
                    case 4:
                        CalcularPeriodo();
                        break;
                    case 5:
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
            Console.WriteLine("Capital (em R$): ");
            float capital = float.Parse(Console.ReadLine());
            Console.WriteLine("Taxa de Juros (em %): ");
            float taxa = float.Parse(Console.ReadLine());
            Console.WriteLine("Periodo (em meses): ");
            int periodo = int.Parse(Console.ReadLine());

            float montante = capital * (float)Math.Pow(1 + (taxa / 100), periodo);
            Console.WriteLine("Montante: R${0:F2}", montante);
        }

        static void CalcularCapital()
        {
            Console.WriteLine("Montante (em R$): ");
            float montante = float.Parse(Console.ReadLine());
            Console.WriteLine("Taxa de Juros: (em %): ");
            float taxa = float.Parse(Console.ReadLine());
            Console.WriteLine("Periodo (em meses): ");
            int periodo = int.Parse(Console.ReadLine());

            float capital = montante / (float)Math.Pow(1 + (taxa / 100), periodo);
            Console.WriteLine("Capital: R${0:F2}", capital);
        }

        static void CalcularTaxa()
        {
            Console.WriteLine("Montante (em R$): ");
            float montante = float.Parse(Console.ReadLine());
            Console.WriteLine("Capital (em R$): ");
            float capital = float.Parse(Console.ReadLine());
            Console.WriteLine("Periodo (em meses): ");
            int periodo = int.Parse(Console.ReadLine());

            float taxa = (float)(Math.Pow((montante / capital), periodo) - 1) * 100;
            Console.WriteLine("Taxa: {0:F1}%", taxa);
        }

        static void CalcularPeriodo()
        {

        }
    }
}
