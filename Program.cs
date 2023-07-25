// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray (string[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i += 1)
    {
        Console.Write($"{arrayToShow[i]} ");
    }    
}

string[] first_array = {"Hello", "2", "world", ":-)"};
string[] second_array = {"1234", "1567", "-2", "computer science"};
string[] third_array = {"Russia", "Denmark", "Kazan"};
string[] test_array = {"How", "are", "YOU", "my friend", "?", "471", "788902", "Column", "RoW", "Just"};

string[] UpdateArray(string[] arrayToUpdate)
{
    int newLength = 0;
    for (int i = 0; i < arrayToUpdate.Length; i += 1)
    {
        if (arrayToUpdate[i].Length <= 3) newLength++;
    }
    string[] newArray = new string[newLength];
    int index = 0;
    for (int i = 0; i < arrayToUpdate.Length; i += 1)
    {
        if (arrayToUpdate[i].Length <= 3)
        {
            newArray[index] = arrayToUpdate[i];
            index++;
        }
    }
    return newArray;
}

string[] modFirst = UpdateArray(first_array);
PrintArray(modFirst);
Console.WriteLine();
string[] modSecond = UpdateArray(second_array);
PrintArray(modSecond);
Console.WriteLine();
string[] modThird = UpdateArray(third_array);
PrintArray(modThird);
Console.WriteLine();
string[] modTest = UpdateArray(test_array);
PrintArray(modTest);