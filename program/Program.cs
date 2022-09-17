string[] SelectionArray(string[] arr, int lenWord)
{
    string[] resArr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lenWord)
        {
            resArr[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref resArr, count);
    return resArr;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] array = { "2", "hello", "world", "res", ":-)", "1234", "1567", "-2", "Russia", "555" };
Console.WriteLine("Задан массив мз строковых элементов: ");
PrintArray(array);
int lengthWord = 3;
string[] resArray = SelectionArray(array, lengthWord);
Console.WriteLine($"Новый массив из строк, длина которых меньше, либо равна {lengthWord} символам: ");
PrintArray(resArray);