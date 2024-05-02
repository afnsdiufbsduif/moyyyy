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
