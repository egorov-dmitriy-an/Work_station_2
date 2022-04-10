// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

Random rand = new Random();
int m = rand.Next(1, 10);
int n = rand.Next(1, 10);

int[,] startArray = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        startArray[i, j] = rand.Next(10, 100);
    }
}
void PrintArray(int[,] curArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(startArray[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}

PrintArray(startArray);



int Summa(int[,] curArray)
{
    int summa = curArray[0, 0];
    {
    for (int i = 0; i < curArray.GetLength(0); i++)
    {
        int summa = curArray[i, 0];
        for (int j = 1; j < curArray.GetLength(1); j++)
        {
            summa = summa + curArray[i, j];
        }
        if (sum < )
    }
}