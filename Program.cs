using System;

class Program
{
    static void Main()
    {
        // Пример произвольного массива
        int[] myArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReversed(myArray, myArray.Length - 1);

        // Задержка экрана
        Console.ReadLine();
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        // Базовый случай: если индекс выходит за границы массива, выходим из рекурсии
        if (index < 0)
            return;

        // Выводим элемент массива
        Console.WriteLine(arr[index]);

        // Рекурсивный вызов для следующего элемента в обратном порядке
        PrintArrayReversed(arr, index - 1);
    }
}
