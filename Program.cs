using System;

class Program
{
    static string[] InputArray()
    {
        Console.Write("Введите размер массива строк: ");
        int size = int.Parse(Console.ReadLine());
        string[] arr = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            arr[i] = Console.ReadLine();
        }
        return arr;
    }

    static string[] FilterShortStrings(string[] arr)
    {
        string[] newArr = new string[arr.Length];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                newArr[index] = str;
                index++;
            }
        }
        Array.Resize(ref newArr, index); // Обрезаем лишние элементы массива
        return newArr;
    }

    static void Main(string[] args)
    {
        // Ввод массива строк
        string[] arr = InputArray();

        // Фильтрация коротких строк
        string[] newArr = FilterShortStrings(arr);

        // Вывод результата
        Console.WriteLine("Новый массив:");
        foreach (string str in newArr)
        {
            Console.WriteLine(str);
        }
    }
}
