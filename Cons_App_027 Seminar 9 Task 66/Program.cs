// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int finish = Convert.ToInt32(Console.ReadLine());

int startTemp =start;
int summa = 0;
while (start <= finish)
{
        summa = summa + start;
        start ++;
}
Console.WriteLine("M = " + startTemp + "; N = " + finish + ". -> " + summa);
