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

void PrintArray(int[] array)
{
    string Print = String.Join(" ", array);
    Console.WriteLine($"[{Print}]");
}

int[] massive = FillArray(8, 1, 9);

PrintArray(massive);

int[] NewMassive(int [] array)
{
    int[] newMassive = new int[array.Length];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        newMassive[j] = massive[i];
        i++;
    }
    return newMassive;
}
int[] newMassive = NewMassive(massive);
PrintArray(newMassive);


