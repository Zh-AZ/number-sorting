using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class NumberSorting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SumOfEvenNumbers();
        SumOfEvenNumbersInARange(10);
        FindingANumber(10);
        SortingBySelection(10);
    }

    private void SumOfEvenNumbers()
    {
        int sum = 0;

        for (int i = 7; i <= 21; i++)
        {
            if (i % 2 == 0)
                sum += i;
        }

        Debug.Log($"Задание 1. Сумма чётных чисел заданного диапазона ({sum})");
    }

    private void SumOfEvenNumbersInARange(int arrayLength)
    {
        Random random = new Random();
        int sum = 0;
        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);

            if (array[i] % 2 == 0)
                sum += array[i];
        }

        Debug.Log($"Задание 2. Сумма чётных чисел в заданном массиве ({sum})");
    }

    private void FindingANumber(int numCompare)
    {
        Random random = new Random();
        int[] array = new int[10];
        bool isExist = false;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);

            if (array[i] == numCompare)
            {
                Debug.Log($"Задание 3. Индекс первого вхождения числа в массив ({i})");
                isExist = true;
            }
        }

        if (!isExist)
            Debug.Log($"Задание 3. Индекс первого вхождения числа в массив ({-1})");
    }

    private void SortingBySelection(int arrayLength)
    {
        Debug.Log("Задание 4. Сортировка выбором");

        Random random = new Random();
        int[] array = new int[arrayLength];
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(1, 101);

        Print("Исходный массив", array);

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        Print("Отсортированный массив", array);
    }

    private void Print(string text, int[] array)
    {
        Debug.Log(text);
        
        for (int i = 0; i < array.Length;i++)
            Debug.Log(array[i]);
    }
}
