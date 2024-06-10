using System;
//
//using System.Windows.Forms;
using Microsoft.VisualBasic;
/*
Autor: David Alejandro Cisneros Delgadillo.
Registro: 21110381.
Fecha: 07/06/2024.
*/
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = new int[5];
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine("Ingresa el valor del elemento " + (i + 1));
                listaNumeros[i] = int.Parse(Console.ReadLine());
            }
            int menor = 0;
            int pos = 0;
            int tem = 0;
            for (int i = 0; i < listaNumeros.Length - 1; i++)
            {
                menor = listaNumeros[i];
                pos = i;
                for (int j = i + 1; j < listaNumeros.Length; j++)
                {
                    if (listaNumeros[j] < menor)
                    {
                        menor = listaNumeros[j];
                        pos = j;
                    }
                }
                if (pos != i)
                {
                    tem = listaNumeros[i];
                    listaNumeros[i] = listaNumeros[pos];
                    listaNumeros[pos] = tem;
                }
            }
            Console.WriteLine("Aqui esta tu lista ordenada de forma acendente:");
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            Console.WriteLine("Aqui esta tu lista ordenada de forma decendente");
            for (int i = listaNumeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            Console.Read();
        }
    }
}

