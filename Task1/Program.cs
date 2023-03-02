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

int[] massive = FillArray(7, 1, 10);
PrintArray(massive);

for (int i = 0; i < massive.Length/2; i++)
{
    int change = massive[i];
    massive[i] = massive[massive.Length - 1 - i];
    massive[massive.Length - 1 - i] = change;
}
PrintArray(massive);