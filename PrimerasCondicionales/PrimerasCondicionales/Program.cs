using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Escribe un programa que pida dos números y que muestre la suma, 
             * la resta, la multiplicación, la media, el máximo y el mínimo.**/

            int num1, num2, num3, segundos, minutos, horas, segundos2; 

            //Console.WriteLine("Escribe un número");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Escribe otro número");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("La suma de " + num1 + " y " + num2 + " = " + (num1+num2));
            //Console.WriteLine("La resta entre " + num1 + " y " + num2 + " = " + (num1 - num2));
            //Console.WriteLine("La división entre " + num1 + " y " + num2 + " = " + (num1 / num2));
            //Console.WriteLine("La multiplicación de " + num1 + " por " + num2 + " = " + (num1 * num2));

            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1 + " es el máximo y " + num2 + " el mínimo ");
            //}
            //else
            //{
            //    Console.WriteLine(num2 + " es el máximo y " + num1 + " el mínimo ");
            //}

            //Console.ReadLine();

            /**
             * Escribe un programa que pida al usuario 3 números. Si el resultado de 
             * la suma de los dos primeros es igual al tercer número, mostrarlo en 
             * pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.**/

            //Console.WriteLine("Escribe un número");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Escribe otro número");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Escribe otro número");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //if ((num1+num2) == num3)
            //{
            //    Console.WriteLine("El resultado de la suma es: " + num3);
            //}
            //else
            //{
            //    Console.WriteLine("El tercer número no es la suma de los dos anteriores. ");
            //}

            //Console.ReadLine();

            /**
             * Escribe un programa que convierta los segundos 
             * a horas, minutos y segundos.**/

            Console.WriteLine("Introduce los segundos: ");
            segundos=Convert.ToInt32(Console.ReadLine());

            horas = segundos / 3600;
            minutos = segundos % 3600 / 60;
            segundos2 = segundos % 3600 % 60;


            Console.WriteLine(segundos + " segundos son " + horas + " h " + minutos + " m " + segundos2 + " s");
            Console.ReadLine();

            /**
             * Escribe un programa que convierta los segundos 
             * a horas, minutos y segundos.**/

        }
















    }
}
