using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pilaaa
    {

        public Nodo cima = new Nodo();
        public void insertar(char n)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = n;

            nuevo.sig = cima;
            cima = nuevo;
        }
        public char Desapilar()
        {
            char obj = cima.dato;
            cima = cima.sig;
            return obj;
        }
        public void mostrar()
        {
            Nodo temp = cima;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp =temp.sig;
            }
        }
    }
}

