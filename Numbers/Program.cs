 using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, s, r, m;
           float div;
           string va;
           
           
           
            Console.WriteLine("Ingrese un numero");

            va = Console.ReadLine();

            n1 = int.Parse(va);
            
            Console.WriteLine("Ingrese otro numero");

            va = Console.ReadLine();

            n2 = int.Parse(va);

            s = n1 + n2;

            r = n1 - n2;

            m = n1 * n2;

            div = n1 / n2;

            Console.WriteLine("El resultado de la suma es: " + s);
            Console.WriteLine("El resultado de la resta es: " + r);
            Console.WriteLine("El resultado de la multiplicacion es: " + m);
            Console.WriteLine("El resultado de la division es: " + div);
            Console.ReadKey();
        }
    }
}
