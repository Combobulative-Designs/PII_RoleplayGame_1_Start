using System;
using System.Collections;

namespace Library
{
    public class Hechizo
    {
        public string Nombre{get; private set;}
        public int Ataque {get; private set;}
        
        public Hechizo(string pnombre ,int pataque)
        {
            this.Nombre=pnombre;
            this.Ataque=pataque;
        }
    }
}