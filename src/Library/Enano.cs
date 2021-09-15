using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Enano
    {
        private static List<Enano> personajes = new List<Enano>();
        public string Nombre{get; set;}
        public int Vida{get; set;}
        public ArrayList Items;
        
        public Enano(string pnombre,int pvida)
        {
            this.Nombre=pnombre;
            this.Vida=pvida;
            this.Items=new ArrayList();

            personajes.Add(this);
        }

        public void QuitarElemetno(Elemento pElemento)
        {
           if(this.Items.Contains(pElemento))
           {
               this.Items.Remove(pElemento);
           }
        }
        
        public void AgregarElemento(Elemento pElemento)
        {
            if(!this.Items.Contains(pElemento))
            {
                this.Items.Add(pElemento);
            }
        }
        
        public int CalcularDefensa()
        {
            int xretorno=0;
            foreach (Elemento elem in this.Items)
            {
                xretorno=xretorno+elem.Defensa;
            }
            return xretorno;
        }
        //Ataque a Arquero
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

        //Ataque a Enano
        public void Ataque(Elemento pElem, Enano pEnano)
        {
            if(this.Items.Contains(pElem))
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

        //Ataque Elfo
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

        //Ataque Mago
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
        public static Enano GetPersonaje(string nombre)
        {
            return personajes.Find(match => match.Nombre == nombre.Trim());
        }
        public static List<Enano> GetPersonajes()
        {
            return personajes;
        }

    }
}