/*
Autor: David Alejandro Cisneros Delgadillo.
Registro: 21110381.
Fecha: 07/06/2024.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Arreglo original:");
        PrintArray(arr);

        NaturalMergeSort(arr);

        Console.WriteLine("\nArreglo ordenado:");
        PrintArray(arr);
    }

    // Función principal de Natural Merging
    static void NaturalMergeSort(int[] arr)
    {
        int n = arr.Length;
        int[] temp = new int[n];
        bool merged = true;

        while (merged)
        {
            merged = false;
            int i = 0;

            while (i < n)
            {
                int left = i;
                int mid = FindNextSortedSubarray(arr, i, out int right);

                if (mid < n)
                {
                    Merge(arr, temp, left, mid, right);
                    merged = true;
                }

                i = right + 1;
            }
        }
    }

    // Función para encontrar el siguiente subarreglo ordenado
    static int FindNextSortedSubarray(int[] arr, int start, out int end)
    {
        int n = arr.Length;
        int i = start;

        while (i < n - 1 && arr[i] <= arr[i + 1])
            i++;

        end = i;
        return i + 1;
    }

    // Función para combinar dos subarreglos ordenados
    static void Merge(int[] arr, int[] temp, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];
        while (j <= right)
            temp[k++] = arr[j++];

        for (int p = left; p <= right; p++)
            arr[p] = temp[p];
    }

    // Función para imprimir el arreglo
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}