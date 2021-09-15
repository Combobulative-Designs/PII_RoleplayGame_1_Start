using System;
using System.Collections;

namespace Library
{
    public class Hechizo
    {
        public string Nombre{get; set private;}
        public int Ataque {get; set private;}
        public int Defensa {get ;set private;}
        
        public Hechizo(string pnombre ,int pataque, int pdefensa)
        {
            this.Nombre=pnombre;
            this.Ataque=pataque;
            this.Defensa=pdefensa;
        }
    }
}