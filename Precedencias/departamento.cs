namespace Precedencias
{

    using System;
    public class departamento : house
    {
        public departamento(puerta puerta) : base(puerta,50)
        {
            
        }

        public void ShowData (){

            Console.WriteLine("Mi puerta es: " + puerta.ShowData() + " Y mis metros cuadrados son: " + area);

        }


    }
}