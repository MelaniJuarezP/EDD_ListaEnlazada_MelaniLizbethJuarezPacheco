using System;
using System.Collections.Generic;
using System.Text;

namespace EDD_ListaEnlazada_MelaniLizbethJuarezPacheco
{
    public class Nodo
    {
        //campos
        private int dato;
        private Nodo siguiente;

        //metodos
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        //propiedades
        public int Dato
        {
            get{  return this.dato; }
            set{ this.dato = value; }
        }
        public Nodo Siguiente
        {
            get{ return this.siguiente; }
            set{ this.siguiente = value; }
        }
    }
}
