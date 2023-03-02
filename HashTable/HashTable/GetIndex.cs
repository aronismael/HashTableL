using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class GetIndex
    {
        public static List<string> NombreObtenidos = new List<string>();
        public static Hashtable codigoAscii = new Hashtable();
        public static Dictionary<int, NodoLista> hashtableWords = new Dictionary<int, NodoLista>();
        public static int SumaAscii=0;

        public Dictionary<int, NodoLista> GetMod(List<string> ListNombre)
        {
            NombreObtenidos.AddRange(ListNombre);

            NodoLista nodo = new NodoLista();

            //List<string> Letters = new List<string>(); 

            foreach (string Nombre in NombreObtenidos)
            {
                SumaAscii = 0;

                foreach (char Letter in Nombre)
                {                                                                                
                   SumaAscii = SumaAscii + Convert.ToInt32(Letter);                    
                }

                //Console.WriteLine((SumaAscii / Nombre.Length) % Nombre.Length);

                bool ThereIsNext = true;

                //Console.WriteLine((SumaAscii / Nombre.Length) % Nombre.Length);
                //Console.WriteLine((SumaAscii / Nombre.Length));

                nodo = hashtableWords.ContainsKey(SumaAscii % Nombre.Length) ? hashtableWords[SumaAscii % Nombre.Length] : null ;

                if (nodo != null)
                {
                    hashtableWords[SumaAscii % Nombre.Length] =GetLastNode(nodo, Nombre);
                }
                else 
                {
                    nodo = new NodoLista();
                    nodo.valor = Nombre;
                    hashtableWords[SumaAscii % Nombre.Length] = nodo;
                }

            }

            return hashtableWords;
        }

        public static NodoLista GetLastNode(NodoLista nodo, string NewValue)
        {
            if (nodo.Siguiente != null)
            {
                nodo.Siguiente = GetLastNode(nodo.Siguiente, NewValue);
            }
            else
            {
                NodoLista nodoSiguiente = new NodoLista();
                nodoSiguiente.valor = NewValue;

                nodo.Siguiente = nodoSiguiente;
            }

            return nodo;
        }
    }
}
