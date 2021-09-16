using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Enano
    {
        private static List<Enano> personajes = new List<Enano>();
        public string Nombre{get; private set;}
        public int Vida{get; set;}
        public ArrayList Items;
        public int VidaInicial{get; private set;}


       /// <summary>
        /// Constructor de la clase. Al crear una instancia
        /// la añade a la variable de clase 'personajes'
        /// </summary>
        /// <param name="nombre">string: Nombre del personaje.</param>
        /// <param name="vida">int: Vida del personaje.</param> 
        public Enano(string pnombre,int pvida)
        {
            this.Nombre=pnombre;
            this.Vida=pvida;
            this.Items=new ArrayList();
            this.VidaInicial=pvida;

            personajes.Add(this);
        }
        
        //Destructor
        ~Enano()
        {
            personajes.Remove(this);
        }

        /// <summary>
        /// Des-equipar un item del personaje.
        /// </summary>
        /// <param name="pElemento">Elemento: item a des-equipar.</param>
        public void QuitarElemetno(Elemento pElemento)
        {
           if(this.Items.Contains(pElemento))
           {
               this.Items.Remove(pElemento);
           }
        }
        
        /// <summary>
        /// Equipar un item al personaje.
        /// </summary>
        /// <param name="pElemento">Elemento: item a equipar.</param>
        public void AgregarElemento(Elemento pElemento)
        {
            if(!this.Items.Contains(pElemento))
            {
                this.Items.Add(pElemento);
            }
        }
        
        /// <summary>
        /// Devuelve la defensa combinada de todos los
        /// items equipados.
        /// </summary>
        /// <returns>int: defensa calculada.</returns>
        public int CalcularDefensa()
        {
            int xretorno=0;
            foreach (Elemento elem in this.Items)
            {
                xretorno=xretorno+elem.Defensa;
            }
            return xretorno;
        }

        /// <summary>
        /// Atacar a un arquero con un item equipado.
        /// </summary>
        /// <param name="pElem">Elemento: item a utilizar para el ataque.</param>
        /// <param name="pArquero">Arquero: personaje objetivo a atacar.</param>
        public void Ataque(Elemento pElem, Arquero pArquero)
        {
            if(this.Items.Contains(pElem))
            {
                int xDefensaArquero=pArquero.CalcularDefensa();
                int xDañoElemento=pElem.Ataque;
                if(xDefensaArquero<xDañoElemento)
                {
                    int xVidaEnemigo=pArquero.Vida-(xDañoElemento-xDefensaArquero);
                    pArquero.Vida=xVidaEnemigo;
                }
            }
        }

        /// <summary>
        /// Atacar a un enano con un item equipado.
        /// </summary>
        /// <param name="pElem">Elemento: item a utilizar para el ataque.</param>
        /// <param name="pEnano">Enano: personaje objetivo a atacar.</param>
        public void Ataque(Elemento pElem, Enano pEnano)
        {
            if(this.Items.Contains(pElem))
            {
                if(!Object.ReferenceEquals(this,pEnano))
                {
                    int xDefensaEnano=pEnano.CalcularDefensa();
                    int xDañoElemento=pElem.Ataque;
                    if(xDefensaEnano<xDañoElemento)
                    {
                        int xVidaEnemigo=pEnano.Vida-(xDañoElemento-xDefensaEnano);
                        pEnano.Vida=xVidaEnemigo;
                    }
                }
            }
        }

        /// <summary>
        /// Atacar a un elfo con un item equipado.
        /// </summary>
        /// <param name="pElem">Elemento: item a utilizar para el ataque.</param>
        /// <param name="pElfo">Elfo: personaje objetivo a atacar.</param>
        public void Ataque(Elemento pElem, Elfo pElfo)
        {
            if(this.Items.Contains(pElem))
            {
                int xDefensaElfo=pElfo.CalcularDefensa();
                int xDañoElemento=pElem.Ataque;
                if(xDefensaElfo<xDañoElemento)
                {
                    int xVidaEnemigo=pElfo.Vida-(xDañoElemento-xDefensaElfo);
                    pElfo.Vida=xVidaEnemigo;
                }
            }
        }

        /// <summary>
        /// Atacar a un mago con un item equipado.
        /// </summary>
        /// <param name="pElem">Elemento: item a utilizar para el ataque.</param>
        /// <param name="pMago">Mago: personaje objetivo a atacar.</param>
        public void Ataque(Elemento pElem, Mago pMago)
        {
            if(this.Items.Contains(pElem))
            {
                int xDefensaMago=pMago.CalcularDefensa();
                int xDañoElemento=pElem.Ataque;
                if(xDefensaMago<xDañoElemento)
                {
                    int xVidaEnemigo=pMago.Vida-(xDañoElemento-xDefensaMago);
                    pMago.Vida=xVidaEnemigo;
                }
            }
        }

        /// <summary>
        /// Reinicia la vida del personaje a su vida inicial.
        /// </summary>
        public void Heal()
        {
            this.Vida = this.VidaInicial;
        }

        /// <summary>
        /// Devuelve un Enano por su nombre.
        /// </summary>
        /// <param name="pNombre">string: nombre del arquero a devolver.</param>
        /// <returns>Enano: personaje encontrado.</returns>
        public static Enano GetPersonaje(string pNombre)
        {
            return personajes.Find(match => match.Nombre == pNombre.Trim());
        }

        /// <summary>
        /// Devuelve la lista de enanos creados.
        /// </summary>
        /// <returns>List: listado de enanos.</returns>
        public static List<Enano> GetPersonajes()
        {
            return personajes;
        }

    }
}