using System;

namespace Miercoles28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {
                Pantalla pan = new Pantalla();
                pan.Boton = "encendido";
                pan.Pulgadas = 28;
                pan.Color = "negro";
                pan.Dimenciones = 28;
                pan.Marca = "dell";
                Console.WriteLine($"Boton = {pan.Boton}");
                Console.WriteLine($"Pulgadas = {pan.Pulgadas}");
                Console.WriteLine($"Color = {pan.Color}");
                Console.WriteLine($"Dimenciones = {pan.Dimenciones}");
                Console.WriteLine($"Marca = {pan.Marca}"); 
                pan.IngresarPantalla();
                pan.Imprimir();
                pan.Modificar("SAMSUNG", 28, "GRIS");
                pan.Imprimir();


            }

        }
    }
}
