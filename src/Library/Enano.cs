using System;
using System.Collections;

namespace Library
{
    public class Enano
    {
        public string Nombre{get; set;}
        public int Vida{get; set;}
        public ArrayList Items;
        
        public Enano(string pnombre,int pvida)
        {
            this.Nombre=pnombre;
            this.Vida=pvida;
            this.Items=new ArrayList();
        }

        public void QuitarElemetno(Elemento pElemento)
        {
            int xcont=0;
            foreach (Elemento elem in this.Items)
            {

                if(pElemento==elem)
                {
                    this.Items.Remove(elem);
                }
                xcont++;
            }
        }
        
        public void AgregarElemento(Elemento pElemento)
        {
            bool xesta=false;
            foreach (Elemento elem in this.Items)
            {
                if(pElemento==elem)
                {
                    xesta=true;
                }
            }
            if(xesta==false)
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

        /*  Revisar que solo ataque a un personaje
            Revisar que el elemento con el que se ataca lo tenga el personaje que ataca.
            Si el daño del elemento es menor a la defensa del otro personaje entonces no resta nada.
            Si el daño del elemento es mayor que la defensa del otro persoanje entonces le resta la vida
        */
        public void Ataque(Elemento pElem, Elfo pElfo, Enano pEnano, Arquero pArquero, Mago pMago)
        {
            if(TieneElElemento(this.Items,pElem)==true)
            {
                if(pElfo!=null)
                {
                    if(pEnano==null && pArquero==null && pMago==null)
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
                else if (pEnano!=null)
                {
                    if(pElfo==null && pArquero==null && pMago==null)
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
                else if (pArquero!=null)
                {
                    if(pElfo==null && pEnano==null && pMago==null)
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
                else if (pMago!=null)
                {
                    if(pElfo==null && pEnano==null && pArquero==null)
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
            }
        }
        public bool TieneElElemento(ArrayList pItems,Elemento pElemento)
        {
            bool xretorno=false;
            foreach (Elemento elem in pItems)
            {
                if(elem==pElemento)
                {
                    xretorno=true;   
                }
            }
            return xretorno;
        }

    }
}