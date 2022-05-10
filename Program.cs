string[] array = { "213f", "234", "gbff", "gpw", "22", "t", "-341" };

void PrintArray(string[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine();
}

(int, string[]) CountingElementsNewArray(string[] arg)
{
    int count = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i].Length < 4) count++;
    }
    return (count, arg);
}

string[] ThreeCharactersArray((int count, string[] array) arg)
{
    string[] newArray = new string[arg.count];
    for (int i = 0, j = 0; i < arg.array.Length; i++)
    {
        if (arg.array[i].Length < 4)
        {
            newArray[j++] = arg.array[i];
        }
    }
    return newArray;
}

PrintArray(array);
PrintArray(ThreeCharactersArray(CountingElementsNewArray(array)));