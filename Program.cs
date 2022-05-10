string[] array = { "213f", "234", "gbff", "gpw", "22", "t", "-341" };

void PrintArray(string[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine();
}




PrintArray(array);