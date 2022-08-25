using System;
using System.Globalization;

namespace Terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular
            //com uma casa decimal, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno
            //Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno
            //ambos com duas casas decimais, conforme exemplo.

            //Entrada
            //10.0
            //30.0
            //200.00

            //Saida
            //Area = 300.0
            //Preço = 60000.00

            // VARIAVEIS

            double largura, comprimento, valorm2, area, valortt; 
            




            Console.WriteLine("================");
            Console.WriteLine("informe o largura do terreno");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("informe o comprimento do terreno");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("informe o largura do M²");
            valorm2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Area de cálculo

            area = largura * comprimento;
            valortt = area * valorm2;

            //Resultado
            Console.Clear();

            Console.WriteLine("====== Resultados ======");
            Console.WriteLine("Área do terreno é:" + area.ToString("F2", CultureInfo.InvariantCulture)
                + " M² ");

            Console.WriteLine("Valor do Terreno é R$:" + valortt.ToString("F2",
                CultureInfo.InvariantCulture));
        }
    }
}
