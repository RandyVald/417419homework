
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int GetCount(string[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreatNewArr(string[] Array, int count)
{
    string[] NewArr = new string[count];
    int k = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NewArr[k] = Array[i];
            k++;
        }
    }
    return NewArr;
}



Console.Clear();

string[] Array = ["Hello", "2", "world", ":-)"];
int Count = GetCount(Array);
string[] NewArr = CreatNewArr(Array, Count);

System.Console.WriteLine(Count);