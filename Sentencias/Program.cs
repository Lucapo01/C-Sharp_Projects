using System;

namespace Sentencias
{
    class Program
    {
        static void Main(string[] args)
        {
             int cantidad = 0;
             decimal resultado =0m;
             int cuenta = 0;
             string va;



             Console.WriteLine("Ingrese cantidad de numeros a promediar");
             va = Console.ReadLine();

             int.TryParse(va, out cantidad);

             Console.WriteLine(cantidad);

             int[] numeros = new int [cantidad];
             

             for (int f = 0; f < cantidad; f++  ){

                 Console.WriteLine("Ingrese el "+(f+1)+" valor a promediar");

                  va = Console.ReadLine();
                  numeros[f] = Int32.Parse(va);
                  cuenta = cuenta + numeros[f]; 

             }

            

              resultado = (decimal)cuenta / (decimal)cantidad;
            

             Console.Write("El resultado es: ");
             Console.WriteLine(resultado);

             
            
        }
    }
}
