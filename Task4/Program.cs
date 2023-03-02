// See https://aka.ms/new-console-template for more information
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int n = Prompt("Введите число: ");
int numb1 = 0;
int numb2 = 1;
Console.Write("0 1 ");

for (int i = 0; i < n - 2; i++)
{
    int result = numb1 + numb2;
    Console.Write(result + " ");
    numb1 = numb2;
    numb2 = result;    
}
