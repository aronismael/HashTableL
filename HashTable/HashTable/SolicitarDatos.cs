using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class SolicitarDatos
    {
        public static List<string> Nombres = new List<string>();
        public static bool FirstTime = true;
        public static bool OtherName = true;
        public static Hashtable codigoAscii = new Hashtable();
        public static int NumTotal = 3;

        public static void GetDatos()
        {
            int Respuesta = 0;

            try
            {
                Console.WriteLine("Escribe 1 para colocar mas, escribe 0 para no colocar mas elementos\n");               

                while (OtherName)
                {

                    if (!FirstTime)
                    {
                        Console.WriteLine("Escribe otro nombre");
                        Nombres.Add(Convert.ToString(Console.ReadLine()));

                        Console.Clear();

                        Console.WriteLine("Do you want to write other name");

                        Respuesta = Convert.ToInt32(Console.ReadLine());

                        OtherName = Respuesta == 1 ? true : false;
                    }

                    if (FirstTime)
                    {
                        Console.WriteLine("Escribe un nombre");
                        Nombres.Add(Convert.ToString(Console.ReadLine()));

                        Console.Clear();

                        Console.WriteLine("Do you want to write other name");

                        Respuesta = Convert.ToInt32(Console.ReadLine());
                        OtherName = Respuesta == 1 ? true : false;

                        FirstTime = false;
                    }
                    
                }                

                if (!OtherName)
                {
                    GetIndex GetMod = new GetIndex();
                    Dictionary<int, NodoLista> hashtableWords = GetMod.GetMod(Nombres);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Escriebe el nombre con caracteres alfabeticos");
                GetDatos();
            }

        }
    }
}
