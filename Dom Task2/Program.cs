// See https://aka.ms/new-console-template for more information
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());;
}

double k1 = Prompt("Введите коэффицент первой прямой: ");
double b1 = Prompt("Введите константу первой прямой: ");
double k2 = Prompt("Введите коэфффицент второй прямой: ");
double b2 = Prompt("Введите константу второй прямой: ");

bool CheckLines(double k1, double b1, double k2, double b2)
{
    if (k2 - k1 == 0)
    {
        if (b2 - b1 == 0)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;

}
if (CheckLines(k1, b1, k2, b2))
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*(b2 - b1)/(k1 - k2) + b1;
    Console.WriteLine($"Прямые пересекаются на координатах: ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}
