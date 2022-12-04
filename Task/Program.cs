string Prompt(string message)
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
string[] CreateArray()
{
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[50];
    System.Console.WriteLine($"Введите 'exit' для завершения ввода");
    for (count = 0; value != "exit"; count++)
    {
        value = Prompt($"Введите {count + 1}-ое значение ");
        if (value != "exit")
        {
            secondArray[count] = value;
        }
    }
    string[] array = new string[count - 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = secondArray[i];
    }
    return array;
}
string[] CheckArray(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    { // Перебор массива по элементам
        if (array[i].Length < 4) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    { // Проверяем длину введенной строки
        if (array[j].Length < 4)
        {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}

string[] array = CreateArray();
System.Console.Write("Полученные данные: ");
ShowArray(array);
System.Console.Write("Результат: ");
ShowArray(CheckArray(array));

