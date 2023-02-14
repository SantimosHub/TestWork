// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] --> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -->["-2"]
// ["Russia", "Denmark", "Kazan"] --> []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите массив строк через пробел");
string userString = Console.ReadLine();
string[] userArray = userString.Split(' ');

Console.Write("Пользовательский массив: ");
PrintArray(userArray);

string resultString = "";
int maxLenght = 3;
foreach (string item in userArray)
{
    if (item.Length <= maxLenght)
    {
        resultString += item + " ";
    }
}

string[] resultArray = resultString.Split(' ');
Console.Write($"Элементы <={maxLenght} символам : ");
PrintArray(resultArray);



