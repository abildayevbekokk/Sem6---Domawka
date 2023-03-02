// See https://aka.ms/new-console-template for more information
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void ToBinar(int a)
{
    int n = a % 2;
    if (a >= 2)
        ToBinar(a/2);
    Console.Write(n);
}

int number = Prompt("Введите число: ");
ToBinar(number);
