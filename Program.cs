
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

void PrintArray(string[] Array)

{
    for (int i = 0; i < Array.Length; i++)

    {

        Console.Write($"{Array[i]} ");

    }
}


Console.Clear();

string[] Array = ["Hello", "2", "world", ":-)"];
int Count = GetCount(Array);
string[] NewArr = CreatNewArr(Array, Count);
PrintArray(NewArr);