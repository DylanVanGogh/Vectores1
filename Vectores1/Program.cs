using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones");

            vectorInicializar();
            Console.ReadKey();
        }
        public static void vectorInicializar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir el vector
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n=============\n");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Elemento índice {0} -->{1}", (i + 1), x[i]);
            }
            //sumatoria de los elementos del vector

            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }
            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("El promedio es {0}", suma / x.Length);
            ///////

        }
    }
}
