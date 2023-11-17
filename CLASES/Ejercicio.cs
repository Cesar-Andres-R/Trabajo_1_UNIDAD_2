using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Timers;

namespace Trabajo_1_UNIDAD_2.CLASES
{
    public class Ejercicio
    {
        /*
        public void Trabajo_1_Ejercicio_1()
        {
            int[] numeros = { 1, 2, 3, 4, 5};

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        */


        /*
        public void Trabajo_1_Ejercicio_2()
        {
            int[] numeros =  new int[5];

            Console.WriteLine("Ingrese datos al array");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los elementos dentro del array son:");
            for (int s = 0;s < numeros.Length;s++)
            {
                
                Console.WriteLine(numeros[s]);
            }
        }
        */

        /*
        public void Trabajo_2_Ejercicio_1()
        {
            int[] numeros =  new int[10];
            int sumar = 0;

            Console.WriteLine("Ingresa valores al array");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                sumar += numeros[i] / 2;
                
            }
            Console.WriteLine("La media de los datos dentro del array");
            Console.WriteLine(sumar);
        }
        */
        
        /*
        public void Trabajo_3_Ejercicio_1()
        {

            Console.WriteLine("Ingrese la Longitud que requieras");
            int[] datos = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Ingrese el multiplo");
            datos[0] = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < datos.Length; i++)
            {
                
            }
            Console.WriteLine("La el multiplo es: ");
            Console.WriteLine(multiplo);
        }
        */


        //public void Trabajo_3_Ejercicio_1()
        //{
        //    //Console.WriteLine("Ingrese la longitud que requiera");
        //    //int[] numeros = new int[Convert.ToInt32(Console.ReadLine())];
        //    //int[] numeros = new int[3];
        //    int multiplo = 1;

        //    Console.WriteLine("Ingrese el multiplo");
        //    //numeros[0] = Convert.ToInt32(Console.ReadLine());
        //    //numeros[1] = numeros[0] * 2;
        //    //numeros[2] = numeros[0] * 3;
            

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        numeros[0] = Convert.ToInt32(Console.ReadLine());
        //        numeros[1] *= multiplo++; 
        //    }
        //    Console.WriteLine(numeros);


            
        //}
    }
}
