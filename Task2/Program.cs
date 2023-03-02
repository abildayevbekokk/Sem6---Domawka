// See https://aka.ms/new-console-template for more information
bool IsTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int firstSide = Prompt("Введите первое число");
int secondSide = Prompt("Введите второе число");
int thirdSide = Prompt("Введите третье число");

Console.WriteLine(IsTriangle(firstSide, secondSide, thirdSide) ? "Является треугольником" : "Не является треугольником");