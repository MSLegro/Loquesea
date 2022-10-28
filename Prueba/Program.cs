using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] lista = new int[16];
            Random r = new Random();
            int NumRandom;
            int i = 0;
           

            while (i < lista.Length)
            {
                Boolean resp = false;
                NumRandom = r.Next(0, 16);

                for (int j = 0; j < i; j++)
                {
                    if (NumRandom == lista[j])
                    {
                        resp= true; 
                    }
                }
                if (resp != true)
                {
                    lista[i]=NumRandom;
                    i++;
                }       
            }

            for (int k = 0; k < lista.Length; k++)
            {
                Console.WriteLine("pos "+k+" "+lista[k]);
            }








            //do
            //{ 
            //    for (int j = 0; j <= i; j++)
            //    {
            //        if (lista[j] == NumRandom)
            //        {
            //            Rep = "si";
            //            break;
            //        }  
            //    }
            //    if (Rep != "si")
            //    { 
            //        lista[i] = NumRandom;                    
            //        i++;
            //    }

            //    for (int k = 0; k < lista.Length; k++)
            //    {
            //        Console.WriteLine("Estoy en la pos " + k + "  " + lista[k]);
            //    }
            //} while (i < 15);


            //for (int i = 0; i < lista.Length; i++)
            //{
            //    lista[i] = r.Next(0, 16).ToString();
            //    Console.WriteLine("Estoy en la pos " + i + "  " + lista[i]);

            //}


            Console.ReadKey();



        }
    }
}
