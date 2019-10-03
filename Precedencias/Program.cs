using System;

namespace Precedencias
{
    class Program
    {

        static void Main(string[] args)
        {
            puerta puerta = new puerta();
            puerta.color = "rojo";
            departamento departamento = new departamento(puerta);
            persona persona = new persona();

            persona.house = departamento;
            persona.nombre = "Juan Domingo";

            departamento.ShowData();
            persona.ShowData();
            puerta.ShowData();

        }
    }
}
