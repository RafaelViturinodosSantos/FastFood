using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lanchonete
{
    class Itens
    {
        double cachorroQuente = 4.00;
        double xSalada = 4.50;
        double xBacon = 5.00;
        double torradaSimples = 2.00;
        double refrigerente = 1.50;
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        double Total;

        public Itens(double num1,double num2)
        {
            Num1 = num1;
            Num2 = num2;
            
        }

        public double ValidaItens()
        {
            if (Num1 == 1)
            {
                Num1 = cachorroQuente;
            }
            else if (Num2 == 1)
            {
                Num2 = cachorroQuente;
            }
            else if (Num1 == 2)
            {
                Num1 = xSalada;
            }
            else if (Num2 ==2)
            {
                Num2 = xSalada;
            }
            else if (Num1 == 3)
            {
                Num1 = xBacon;
            }
            else if (Num2 ==3)
            {
                Num2 = xBacon;
            }
            else if (Num1 == 4)
            {
                Num1 = torradaSimples;
            }
            else if (Num2 == 4)
            {
                Num2 = torradaSimples;
            }
            else if (Num1 == 5)
            {
                Num1 = refrigerente;
            }
            else if (Num2 == 5)
            {
                Num2 = refrigerente;
            }
            return  Total = Num1 + Num2;

        }
        public override string ToString()
        {
            return "O total do seu pedido ficou R$: "+ ValidaItens().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

