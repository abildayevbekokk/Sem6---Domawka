// See https://aka.ms/new-console-template for more information
int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(" ", array)}]");
}

int[] InputMassive(int length)
{
    int[] massive = new int[length];
    for (int i = 0; i < length; i++)
    massive[i] = Prompt(":");
    return massive;
}

int PositiveCount(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        count++;
    }
    return count;
}

int[] massive = InputMassive(8);
PrintArray(massive);
Console.WriteLine($"Количество отрицательных чисел = {PositiveCount(massive)}");

