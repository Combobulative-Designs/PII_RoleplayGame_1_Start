using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Elemento
    {
        private static List<Elemento> ListaElemento = new List<Elemento>();
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
            
            ListaElemento.Add(this);
        }

        public static Elemento GetElemento(string nombre)
        {
            return ListaElemento.Find(match => match.Nombre == nombre.Trim());
        }

    }
}