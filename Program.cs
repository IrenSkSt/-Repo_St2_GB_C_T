// Задача - Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void FillArray(string[] arr, int num)
{
    Console.WriteLine("Введите любое слово: ");

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{i + 1} слово: ");
        arr[i] = Console.ReadLine();
    }
}

int SortArray(string[] arr, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max) count++;
    }
    return count;
}

void CreateArrayOnlyMaxSymbol(string[] arr, string[] arrNew, int max, int num)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max) { arrNew[j] = arr[i]; j++; }
    }
}

void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}


int maxSimbol = 3;
int maxNumWords = 5;
Console.WriteLine($"Сколько слов вы хотите ввести? Укажите число не более {maxNumWords}: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Ваш ответ означает, что слова вводить не требуется. Никаких операций со словами производиться не будет. ");

else
{
    if (number > maxNumWords)
    {
        Console.WriteLine("Для проверки работы программы достаточно и 5-ти слов. ");
        number = maxNumWords;
    }

    string[] array = new string[number];
    FillArray(array, number);
    int count = SortArray(array, maxSimbol);

    if (count == 0) Console.Write($"Вы указали слов: {number}, среди которых нет длиной до {maxSimbol} символов.");
    else
    {
        string[] newArray = new string[count];
        CreateArrayOnlyMaxSymbol(array, newArray, maxSimbol, count);

        Console.Write($"Вы указали слов: {number}, из которых {count} длиной до {maxSimbol} символов: ");
        ShowArray(newArray);
    }
}


