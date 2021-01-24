using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma Secuencial
            Mesero1Atiende();
            Mesero2Atiende();
            //Tiempo para ejecutarse: 20 segundos

            //Forma Concurrente
            //----Creación de los hilos----
            System.Threading.Thread Mesero1 =
                new System.Threading.Thread(new System.Threading.ThreadStart(Mesero1Atiende));
            System.Threading.Thread Mesero2 =
                new System.Threading.Thread(new System.Threading.ThreadStart(Mesero2Atiende));
            //Tiempo para ejecutarse: 

            //----Iniciando hilos----
            Mesero1.Start();
            Mesero2.Start();
        }


        public static void Mesero1Atiende()
        {
            for(int i=1; i <= 100; i++)
            {
                Console.WriteLine("Mesero 1 sirve el platillo número " + i);
                //Delay 100 ms
                System.Threading.Thread.Sleep(100);
            }
        }
        public static void Mesero2Atiende()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Mesero 2 sirve el platillo número " + i);
                //Delay 100 ms
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
