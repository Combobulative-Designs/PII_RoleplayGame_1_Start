using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elemento> elementos = PopulateItems();
            List<Hechizo> hechizos = PopulateHechizos();

            Mago mago1 = new Mago("Gandalf", 100);
            mago1.AgregarHechizo(hechizos[0]);
            mago1.AgregarHechizo(hechizos[1]);
            mago1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Baston de Adepto"));
            mago1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Tunica de Mago"));

            Enano enano1 = new Enano("Gimli", 130);
            enano1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Hacha Enana"));
            enano1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Escudo Imperial"));

            Elfo elfo1 = new Elfo("Elrond", 90);
            elfo1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Espada Corta"));
            elfo1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Chaqueta de Cuero"));

            Arquero arquero1 = new Arquero("Legolas", 75);
            arquero1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Arco Elfico"));
            arquero1.AgregarElemento(elementos.Find((elemento) => elemento.Nombre == "Chaqueta de Cuero"));

            arquero1.Ataque(elementos.Find((elemento) => elemento.Nombre == "Arco Elfico"), elfo1);
            Console.WriteLine($"{arquero1.Nombre} ataco a {elfo1.Nombre}. Vida restante: {elfo1.Vida}");

            enano1.Ataque(elementos.Find((elemento) => elemento.Nombre == "Hacha Enana"), null, null, arquero1, null);
            Console.WriteLine($"{enano1.Nombre} ataco a {arquero1.Nombre}. Vida restante: {arquero1.Vida}");
        }

        static List<Elemento> PopulateItems()
        {
            List<Elemento> resultado = new List<Elemento>();
            Elemento espadaCorta = new Elemento("Espada Corta", 0, 25, 2);
            Elemento arcoElfico = new Elemento("Arco Elfico", 0, 10, 0);
            Elemento HachaEnana = new Elemento("Hacha Enana", 0, 45, 5);
            Elemento BastonAdepto = new Elemento("Baston de Adepto", 1.2, 0, 0);

            Elemento EscudoImperial = new Elemento("Escudo Imperial", 0, 0, 50);
            Elemento ChaquetaCuero = new Elemento("Chaqueta de Cuero", 0, 0, 20);
            Elemento TunicaMago = new Elemento("Tunica de Mago", 1.05, 0, 2);

            resultado.Add(espadaCorta);
            resultado.Add(arcoElfico);
            resultado.Add(HachaEnana);
            resultado.Add(BastonAdepto);
            resultado.Add(EscudoImperial);
            resultado.Add(ChaquetaCuero);
            resultado.Add(TunicaMago);

            return resultado;
        }

        static List<Hechizo> PopulateHechizos()
        {
            List<Hechizo> resultado = new List<Hechizo>();

            Hechizo bolaFuego = new Hechizo("Bola de Fuego", 30);
            Hechizo meteoro = new Hechizo("Meteoro", 1500);

            resultado.Add(bolaFuego);
            resultado.Add(meteoro);

            return resultado;

        }
    }
}
