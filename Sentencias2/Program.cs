using System;

namespace Sentencias2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            for (int i = 0; i < 10; i++)
            {
                
            
            
            string fruta;



            Console.WriteLine("Ingrese su fruta: ");


            fruta = Console.ReadLine();



            switch (fruta.ToLower())
            {

                case "naranja":

                    Console.WriteLine("Hay juguito");

                    break;

                case "manzana":

                    Console.WriteLine("Hay tartita");

                    break;

                case "pomelo":

                    Console.WriteLine("Hay termita con pomelo");

                    break;

                default:

                    Console.WriteLine("Se lo tiro por la ventana a un transeunte pseudo comunista");

                    break;

                   

                    


            }

            }
        }
    }
}
