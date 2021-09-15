using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase para un personaje de tipo Arquero.
    /// </summary>
    public class Arquero
    {
        private static List<Arquero> personajes = new List<Arquero>();

        public string Nombre { get; private set; }
        public int Vida { get; set; }
        public ArrayList Items { get; private set; }

        /// <summary>
        /// Constructor de la clase. Al crear una instancia
        /// la añade a la variable de clase 'personajes'
        /// </summary>
        /// <param name="nombre">string: Nombre del personaje.</param>
        /// <param name="vida">int: Vida del personaje.</param>
        public Arquero(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Items = new ArrayList();

            personajes.Add(this);
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

        /// <summary>
        /// Equipar un item al personaje.
        /// </summary>
        /// <param name="elemento">Elemento: item a equipar.</param>
        public void AgregarElemento(Elemento elemento)
        {
            if (!this.Items.Contains(elemento))
                this.Items.Add(elemento);
        }

        /// <summary>
        /// Devuelve la defensa combinada de todos los
        /// items equipados.
        /// </summary>
        /// <returns>int: defensa calculada.</returns>
        public int CalcularDefensa()
        {
            int resultado = 0;
            foreach (Elemento item in this.Items)
            {
                resultado += item.Defensa;
            }
            return resultado;
        }

        /// <summary>
        /// Atacar a un elfo con un item equipado.
        /// </summary>
        /// <param name="item">Elemento: item a utilizar para el ataque.</param>
        /// <param name="objetivo">Elfo: personaje objetivo a atacar.</param>
        public void Ataque(Elemento item, Elfo objetivo)
        {
            if (!this.Items.Contains(item))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = item.Ataque - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

        /// <summary>
        /// Atacar a un enano con un item equipado.
        /// </summary>
        /// <param name="item">Elemento: item a utilizar para el ataque.</param>
        /// <param name="objetivo">Enano: personaje objetivo a atacar.</param>
        public void Ataque(Elemento item, Enano objetivo)
        {
            if (!this.Items.Contains(item))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = item.Ataque - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

        /// <summary>
        /// Atacar a un mago con un item equipado.
        /// </summary>
        /// <param name="item">Elemento: item a utilizar para el ataque.</param>
        /// <param name="objetivo">Mago: personaje objetivo a atacar.</param>
        public void Ataque(Elemento item, Mago objetivo)
        {
            if (!this.Items.Contains(item))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = item.Ataque - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

        /// <summary>
        /// Atacar a un arquero con un item equipado.
        /// </summary>
        /// <param name="item">Elemento: item a utilizar para el ataque.</param>
        /// <param name="objetivo">Arquero: personaje objetivo a atacar.</param>
        public void Ataque(Elemento item, Arquero objetivo)
        {
            if (!this.Items.Contains(item))
                return;

            if (Object.ReferenceEquals(this, objetivo))
                return;

            int daño = item.Ataque - objetivo.CalcularDefensa();

            if (daño > 0)
                objetivo.Vida = (objetivo.Vida > daño) ? objetivo.Vida - daño : 0;  
        }

        /// <summary>
        /// Devuelve un Arquero por su nombre.
        /// </summary>
        /// <param name="nombre">string: nombre del arquero a devolver.</param>
        /// <returns>Arquero: personaje encontrado.</returns>
        public static Arquero GetPersonaje(string nombre)
        {
            return personajes.Find(match => match.Nombre == nombre.Trim());
        }

        /// <summary>
        /// Devuelve la lista de arqueros creados.
        /// </summary>
        /// <returns>List: listado de arqueros.</returns>
        public static List<Arquero> GetPersonajes()
        {
            return personajes;
        }
    }
}