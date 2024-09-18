using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Program
    {
        static void Main(string[] args)

        {
            int op = 10000;
            do 
            {
                Console.Clear();
                Console.WriteLine("-----------ORDENAMIENTO-----------");
                Console.WriteLine("[1]Infija a prefija");
                Console.WriteLine("[2]Infija a posfija");
                Console.WriteLine("[3]Posfija a prefija");
                Console.WriteLine("[4]Prefija a Posfija");
                Console.WriteLine("[0]Salir");
                
                Console.WriteLine("----------------------------------");
                Console.Write("Ingrese opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        Console.WriteLine("-----------INFIJA-PREFIJA-----------");
                        Console.WriteLine("Ingresar Infija: ");
                        string If1 = Console.ReadLine();
                        string r = CalcularINFaPRE(If1);

                        Console.WriteLine("Resultado Prefija: " + "(" + r + ")");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("-----------INFIJA-POSFIJA-----------");
                        Console.WriteLine("Ingresar Infija: ");
                        string If2 = Console.ReadLine();
                        string r2 = CalcularINFaPOS(If2);

                        Console.WriteLine("Resultado Posfija: " + "(" + r2 + ")");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("-----------POSFIJA-PREFIJA-----------");
                        Console.WriteLine("Ingresar posfija: ");
                        string If4 = Console.ReadLine();
                        string r4 = CalcularINFaPRE(If4);
                        Console.WriteLine("Resultado Prefija: " + "(" + r4 + ")");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("-----------PREFIJA-POSFIJA-----------");
                        Console.WriteLine("Ingresar Prefija: ");
                        string If5 = Console.ReadLine();
                        string r5 = CalcularINFaPOS(If5);
                        Console.WriteLine("Resultado Posfija: " + "(" + r5 + ")");
                        Console.ReadKey();
                        break;
                }

            } while (op!=0);
            Console.WriteLine("Saliendo..");
            Console.ReadKey();
        }
        static string CalcularINFaPRE(string pal)
        {
            Pilaaa Cl = new Pilaaa();
            ListaEnlazada Ll = new ListaEnlazada();
            for (int i = pal.Length - 1; i >= 0; i--)
            {
                char c = pal[i];
                if (c == '+' || c == '*' || c == '/')
                {
                    Ll.ListaSalida(c);
                }


                if (c >= 'a' && c <= 'z' || c >= '0' && c <= '9')
                {
                    Cl.insertar(c);
                }
                if (c == ')')
                {
                    Cl.insertar(c);
                }
                else if (c == '(')
                {
                    while (Cl.cima != null )
                    {
                        char n = Cl.Desapilar();
                        if (n != ')')
                        {
                            Ll.ListaSalida(n);
                        }
                    }

                }

            }
            return Ll.Mostar();
        }
        static string CalcularINFaPOS(string pal)
        {
            Pilaaa Cl = new Pilaaa();
            ListaEnlazada Ll = new ListaEnlazada();
            for (int i = 0; i < pal.Length; i++)
            {
                char c = pal[i];
                if (c == '+' || c == '*' || c == '/')
                {
                    Cl.insertar(c);
                } 
                if (c >= 'a' && c <= 'z' || c >= '0' && c <= '9')
                {
                    Ll.ListaSalida(c);
                }
                else if (c == ')')
                {
                    while (Cl.cima != null)
                    {
                        char n = Cl.Desapilar();
                        if (n != '(')
                        {
                            Ll.ListaSalida(n);
                        }
                    }

                }

            }

            return Ll.Mostar();
        }
        static string CalcularPOSaPRE(string pal)
        {
            Pilaaa Cl = new Pilaaa();
            ListaEnlazada Ll = new ListaEnlazada();
            for (int i = pal.Length - 1; i >= 0; i--)
            {
                char c = pal[i];
                if (c == '+' || c == '*' || c == '/')
                {
                    Ll.ListaSalida(c);
                }
                if (c >= 'a' && c <= 'z' || c >= '0' && c <= '9')
                {
                    Cl.insertar(c);
                }
                else if (c == ')')
                {
                    while (Cl.cima != null)
                    {
                        char n = Cl.Desapilar();
                        if (n != '(')
                        {
                            Ll.ListaSalida(n);
                        }
                    }

                }

            }

            return Ll.Mostar();
        }
    }
}
