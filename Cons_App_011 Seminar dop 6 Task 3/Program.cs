Console.Write("Введите число N: ");
double a = Convert.ToDouble(Console.ReadLine());
double n = 3;

double stepen = 0;
double step = 0;

double Step(double result)
{
    while (a >= n)
    {
        a = a / 3;
        stepen = stepen + 1;
        Console.WriteLine(a + ", " + stepen);
        step = stepen;
        Step(a);
    }
return step;
}

Console.WriteLine(Step(a));