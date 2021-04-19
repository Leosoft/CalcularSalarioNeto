using System;

namespace CalcularSalarioNeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento, salarioBruto,neto, bono;
             
            Console.Write("Ingresa el salario bruto: ");
            salarioBruto = float.Parse(Console.ReadLine());


            if(salarioBruto >= 2000)
            {
                descuento = salarioBruto * 0.13;
                bono = 0.13;
                neto = salarioBruto - descuento + bono;
            }
            else
            {
                descuento = salarioBruto * 0.10;
                bono = 0.10;
                neto = salarioBruto - descuento + bono;
            }

            //ToString("N2") muestra solo 2 numeros decimales luego del calculo del neto.
            Console.WriteLine("el salario neto es: " + "$" + neto.ToString("N2"));
            
        }
    }
}
