using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateItems();
            PopulateHechizos();

            var arquero1 = new Arquero("Chloe von Einzbern", 75);
            arquero1.AgregarElemento(Elemento.GetElemento("Kanshou y Bakuya"));
            arquero1.AgregarElemento(Elemento.GetElemento("Caladbolg II"));
            arquero1.AgregarElemento(Elemento.GetElemento("Holy Shroud"));
            
            Enano xEnano= new Enano("Carlitos",120);
            xEnano.AgregarElemento(Elemento.GetElemento("Espada"));
            xEnano.AgregarElemento(Elemento.GetElemento("Dagas"));
            xEnano.AgregarElemento(Elemento.GetElemento("Escudo"));
            //Console.WriteLine(((Elemento)arquero1.Items[2]).Nombre); Prueba
        }

        static void PopulateItems()
        {

            new Elemento("Caladbolg II", 0, 60, 0);
            new Elemento("Kanshou y Bakuya", 0, 35, 10);
            new Elemento("Holy Shroud", 0, 0, 40);
            new Elemento("Espada",0,80,0);
            new Elemento("Dagas",0,30,0);
            new Elemento("Escudo",0,0,45);
        }

        static void PopulateHechizos()
        {
            //

            //

            //

            //

        }
    }
}
