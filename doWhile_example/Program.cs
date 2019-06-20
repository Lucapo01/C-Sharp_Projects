using System;

namespace doWhile_example
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese la cantidad:");

            char cant = Convert.ToChar(Console.ReadLine());
            bool flag = true;

            do {

                if (char.IsLetter(cant)){

                    Console.WriteLine("Ingrese un numero:");
                }

                else {

                    flag = false;
                }

             } while (flag);

                int cantInt = (int)Char.GetNumericValue(cant);
                int j = 0;

                while (cantInt > j)
                {
                    Console.WriteLine("Pasame un numero");
                    int numero = Convert.ToInt32(Console.ReadLine ());
                    Console.WriteLine("Su numero es:" + numero);
                    j = j+1;
                }

                
            
        }
    }
}
