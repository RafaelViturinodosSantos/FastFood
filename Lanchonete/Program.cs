using System;
using System.Globalization;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Itens i;

            Console.WriteLine("Informa o número dos itens que deseja");
            Console.WriteLine("1-CachorroQuente = 4.00");
            Console.WriteLine(" 2-XSalada = 4.50");    
            Console.WriteLine("3 -XBacon = 5.00");
            Console.WriteLine("4 -TorradaSimples = 2.00");
            Console.WriteLine("5 -Refrigerente = 1.50");
            String[] vet = Console.ReadLine().Split(' ');
            double num1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double num2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            i = new Itens(num1, num2);
            i.ValidaItens();

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
