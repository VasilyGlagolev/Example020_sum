// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        double[] array = new double[inputArray.Length];

        // Преобразование строковых элементов вещественного массива
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(inputArray[i]);
        }

        double min = array[0];
        double max = array[0];

        // Поиск минимального и максимального элементов массива
        foreach (double number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        double difference = max - min;

        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }
}


// Программа запрашивает у пользователя элементы массива в виде строки, разделённой запятыми. 
// Затем она преобразует строковые элементы вещественного массива. 
// Далее программа перебирает все числа в массиве и находит минимальный и максимальный элементы, сохраняя их в переменные min и max. 
// Наконец, программа вычисляет разницу между максимальным и минимальным элементами и выводит её на экран.
