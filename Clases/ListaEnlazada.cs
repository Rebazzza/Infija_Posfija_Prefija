using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaEnlazada
    { 
       public Nodo primero = new Nodo();   
       public void ListaSalida(char c)
        {
            Nodo nuevo = new Nodo();    
            nuevo.dato = c;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public string Mostar()
        {
            string r = "";
            Nodo temp = primero;
            while (temp != null)
            {
                r += temp.dato;
                temp = temp.sig;
            }
            return r;
        }
    }
}
