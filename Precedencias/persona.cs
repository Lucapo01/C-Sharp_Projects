namespace Precedencias
{
    using System;
    public class persona
    {
       public string nombre;

        public house house;

        public void ShowData(){

            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Mi casa es: " + house);

        }

        
    }
}