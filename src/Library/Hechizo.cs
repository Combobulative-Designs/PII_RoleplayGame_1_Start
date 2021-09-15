using System;
using System.Collections;
using System.Collections.Generic;
namespace Library
{
    public class Hechizo
    {
        public static List<Hechizo> lista = new List<Hechizo>();
        public string Nombre{get; private set;}
        public int Ataque {get; private set;}
        
        public Hechizo(string pnombre ,int pataque)
        {
            this.Nombre=pnombre;
            this.Ataque=pataque;
            lista.Add(this);
            
        }
      // agregar lista
      // constructor 
      //metodo
        public static Hechizo GetHechizo(string nombre)
        {
            return lista.Find(match => match.Nombre == nombre.Trim());
        }


    }
}
