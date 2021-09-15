using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Elfo
    {
        private static List<Elfo> personajes;

        public string Nombre { get; private set; }
        public int Vida { get; set; }
        public ArrayList Items { get; private set; }
        public Elfo(string Nombre, int Vida)
        {
            this.Nombre = Nombre;
            this.Vida = Vida;
            this.Items = new ArrayList();

            personajes.Add(this);

        }


        public void QuitarElemento(Elemento elemento)
        {
            if (this.Items.Contains(elemento))
                this.Items.Remove(elemento);
        }

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
        /// Devuelve un Elfo por su nombre.
        /// </summary>
        /// <param name="nombre">string: nombre del Elfo a devolver.</param>
        /// <returns>Elfo: personaje encontrado.</returns>
        public static Elfo GetPersonaje(string nombre)
        {
            return personajes.Find(match => match.Nombre == nombre.Trim());
        }

        /// <summary>
        /// Devuelve la lista de Elfos creados.
        /// </summary>
        /// <returns>List: listado de Elfo.</returns>
        public static List<Elfo> GetPersonajes()
        {
            return personajes;
        }

    }
}