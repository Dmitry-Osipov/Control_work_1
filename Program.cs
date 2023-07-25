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
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(".");
        }
    }
}

string[] first_array = {"Hello", "2", "world", ":-)"};
string[] second_array = {"1234", "1567", "-2", "computer science"};
string[] third_array = {"Russia", "Denmark", "Kazan"};

