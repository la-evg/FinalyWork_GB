//Чистим консоль
Console.Clear();

//Метод считывает длину массива
int ReadLenghtArray()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int lenghtArray = int.Parse(Console.ReadLine());
    return lenghtArray;
}

//Метод считывает слова и возвращает массив слов
string[] ReadArray(int lenghtArray)
{
    string[] inputArray = new string[lenghtArray];
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово: ");
        inputArray[i] = Console.ReadLine() ?? "";
    }
    return inputArray;
}

// Метод циклом проходится по массиву, если элемент состоит из 3 или меньше элементов то добавляет его в итоговый массив
string[] CheckArray(string[] inputArray)
{
    string[] outputArray = new string[0];
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            //Метод Resize изменяет длину массива
            Array.Resize(ref outputArray, outputArray.Length + 1);
            outputArray[count] = inputArray[i];
            count++;
        }
    }
    return outputArray;
}

//Метод выводит на печать массив
void PrintArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write($"{inputArray[i]}, ");
    }
    Console.Write($"{inputArray[inputArray.Length - 1]}");
    Console.WriteLine("]");
}

string[] firstArray = ReadArray(ReadLenghtArray());
PrintArray(firstArray);
string[] secondArray = CheckArray(firstArray);
PrintArray(secondArray);

