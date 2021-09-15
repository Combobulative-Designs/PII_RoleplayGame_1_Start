using System;
using System.Collections;

namespace Library
{
    public class Elemento
    {
        public int Ataque{get; private set;}
        public int Defensa{get; private set;}
        public double Potenciador{get; private set;}
        public string Nombre{get; private set;}

        public Elemento(string pNombre,double pPotenciador,int pAtaque, int pDefensa)
        {
            this.Ataque=pAtaque;
            this.Defensa=pDefensa;
            this.Potenciador=pPotenciador;
            this.Nombre=pNombre;
        }
    }
}