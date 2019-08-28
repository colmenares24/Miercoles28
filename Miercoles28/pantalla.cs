using System;
using System.Collections.Generic;
using System.Text;

namespace Miercoles28
{
    class Pantalla
    {
        public string Boton { get; set; }
        public int Pulgadas { get; set; }
        public string Color { get; set; }
        public int Dimenciones { get; set; }
        public string Marca { get; set; }
        public Pantalla()
        {

        }
        public Pantalla(string boton, int pulgadas, string color)

        {
            Boton = boton;
            Pulgadas = pulgadas;
            Color = color;

        }
        public Pantalla(int dimenciones, string marca)
        {
            Dimenciones = dimenciones;
            Marca = marca;
        }
        #region Metodos
        public void IngresarPantalla()
        {
            Console.WriteLine("ingrese Marca");
            Marca = Console.ReadLine();
            Console.WriteLine("ingrese las dimenciones");
            Dimenciones = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese color");
            Color = Console.ReadLine();
        }

        public void Imprimir()
        {
            Console.WriteLine($"La marca de la pantalla es:{Marca}");
            Console.WriteLine($"La Dimencion de la pantalla es:{Dimenciones}");
            Console.WriteLine($"El Color de la pantalla es:{Color}");
        }

        public void Modificar(string marca, int pulgadas, string color)
        {
            Marca = marca;
            Pulgadas = pulgadas;
            Color = color;
        }
          #endregion
    }
}