using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class LecturaDictionary
    {
        public static Dictionary<int, NodoLista> ReadingDicctionary = new Dictionary<int, NodoLista>();
        public static int CountDictionary = 0;

        public LecturaDictionary(Dictionary<int, NodoLista> Dictionary)
        {
            foreach (KeyValuePair<int, NodoLista> Date in Dictionary)
            {
                ReadingDicctionary[Date.Key] = Date.Value;
            }

            PrintValues();
        }

        public static void PrintValues()
        {
            NodoLista NodoAux = new NodoLista();

            for (int i=0; i<10;i++)
            {
                if (ReadingDicctionary.ContainsKey(i))
                {
                    Console.Write(i + ": ");
                    IterateNodoList(ReadingDicctionary[i]);
                }
                else
                {
                    Console.Write(i+": null ----------->");
                }

                Console.Write("\n");
            }
        }

        public static void IterateNodoList(NodoLista nodo)
        {
            if (nodo.valor != null)
            {
                Console.Write(nodo.valor);

                if (nodo.Siguiente != null)
                {
                    Console.Write(", ");
                    IterateNodoList(nodo.Siguiente);
                }

            }
        }
    }
}
