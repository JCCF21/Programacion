﻿using System;

namespace LAB2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\tCual es el Mayor Numero");
            Console.WriteLine("===============================");
            
            int[] numeros = new int[3];
            
            Console.WriteLine("Por favor Introduzca Tes numeros");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{i + 1}° Numero:");
                numeros[i] = Validar();

            }
            if (numeros[0] > numeros[1] && numeros[0] > numeros[2])
            {
                Console.WriteLine($"{numeros[0].ToString("#,#")} es el Mayor de todos!");

            }
            else if (numeros[1] > numeros[0] && numeros[1] > numeros[2])
            {
                Console.WriteLine($"{numeros[1].ToString("#,#")} es el Mayor de todos!");
            }
            else
            {
                Console.WriteLine($"{numeros[2].ToString("#,#")} es el Mayor de todos!");
            }
        }
        public static int Validar()
        {
            bool valid = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    valid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Por favor Ingrese Un Numero Valido...");

                }
            } while (!valid);
            return num;
        }
    }
}



