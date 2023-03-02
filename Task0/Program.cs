// See https://aka.ms/new-console-template for more information
int[] FillArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(" ", array)}]");
}