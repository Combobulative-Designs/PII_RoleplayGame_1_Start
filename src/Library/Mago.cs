using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase para un personaje de tipo mago .
    /// </summary>
    public class Mago
    {
        private static List<Mago> personajes;

        public string Nombre { get; private set; }
        public int Vida { get; set; }
        public ArrayList Items { get; private set; }
        public ArrayList Hechizos { get; private set; }

   /// <summary>
   /// constructor del mago
   /// </summary>
   /// <param name="nombre"> nombre del mago</param>
   /// <param name="vida">vida del mago</param>
        public Mago(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Items = new ArrayList();
            this.Hechizos = new ArrayList();

            personajes.Add(this);
        }
        public void QuitarHechizo(Hechizo hechizo)
        {
            if (this.Hechizos.Contains(hechizo))
                this.Hechizos.Remove(hechizo);
        }

        /// <summary>
        /// Des-equipar un item del personaje.
        /// </summary>
        /// <param name="elemento">Elemento: item a des-equipar.</param>
        public void QuitarElemento(Elemento elemento)
        {
            if (this.Items.Contains(elemento))
                this.Items.Remove(elemento);
        }
        public void AgregarHechizo(Hechizo hechizo)
        {
         if (!this.Hechizos.Contains(hechizo))
                this.Hechizos.Add(hechizo);
        }

        /// <summary>
        /// Equipar un item al personaje.
        /// </summary>
        /// <param name="elemento">Elemento: item a equipar.</param>
        public void AgregarElemento(Elemento elemento)
        {
            if (!this.Items.Contains(elemento))
                this.Items.Add(elemento);
        }

   
        public int CalcularDefensa()
        {
            int resultado = 0;
            foreach (Elemento item in this.Items)
            {
                resultado += item.Defensa;
            }
            return resultado;
        }
        public double CalcularPotenciador()
        {
            double resultado=1;
            foreach (Elemento item in this.Items)           
            {
                if (item.Potenciador >0)
                {
                    resultado= resultado*item.Potenciador;

                }
            }
            return resultado;


        }
        /// <summary>
        /// Atacar a un elfo con un item equipado.
        /// </summary>
        /// <param name="item">Elemento: item a utilizar para el ataque.</param>
        /// <param name="objetivo">Elfo: personaje objetivo a atacar.</param>
        public void Ataque(Hechizo hechizo, Elfo objetivo)
        {
            if (!this.Hechizos.Contains(hechizo))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = (int)(hechizo.Ataque*this.CalcularPotenciador()) - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

  
        public void Ataque(Hechizo hechizo, Enano objetivo)
        {
            if (!this.Hechizos.Contains(hechizo))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = (int)(hechizo.Ataque*this.CalcularPotenciador()) - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }


        public void Ataque(Hechizo hechizo, Mago objetivo)
        {
            if (!this.Hechizos.Contains(hechizo))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = (int)(hechizo.Ataque*this.CalcularPotenciador()) - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }


        public void Ataque(Hechizo hechizo, Arquero objetivo)
        {
            if (!this.Hechizos.Contains(hechizo))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = (int)(hechizo.Ataque*this.CalcularPotenciador()) - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

   
        public static Mago GetPersonaje(string nombre)
        {
            return personajes.Find(match => match.Nombre == nombre.Trim());
        }


        public static List<Mago> GetPersonajes()
        {
            return personajes;
        }

    }
}