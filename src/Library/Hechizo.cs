using System;
using System.Collections;

namespace Library
{
    public class Hechizo
    {
        public string Nombre{get; private set;}
        public int Ataque {get; private set;}
        public int Defensa {get; private set;}
        
        public Hechizo(string pnombre ,int pataque, int pdefensa)
        {
            this.Nombre=pnombre;
            this.Ataque=pataque;
            this.Defensa=pdefensa;
        }
    }
}