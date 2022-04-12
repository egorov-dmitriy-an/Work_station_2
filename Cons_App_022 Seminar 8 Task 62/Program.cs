// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] spiral = new int[m, n];

int[,] FillArray(int k, int l, int count)
{
    if (count <= m * n)
    {
        int i = k;
        int j = l;
        for (j = k; j < n - k; j++)
        {
            count++;
            spiral[i, j] = count;
        }
        if (count < m * n)
        {
            j--;
            k = i;
            l = j;
            for (i = k + 1; i < m - k; i++)
            {
            count++;
            spiral[i, j] = count;
            }
            if (count < m * n)
            {
                i--;
                k = i;
                l = j;
                for (j = k - 1; j >= m - k - 1; j--)
                {
                count++;
                spiral[i, j] = count;
                }
                if (count < m * n)
                {
                    j++;
                    k = i;
                    l = j;
                    for (i = k - 1; i > n - k - 1; i--)
                    {
                        count++;
                        spiral[i, j] = count;
                    }
                    if (count < m * n)
                    {
                        i++;
                        k = i;
                        l = j + 1;
                        FillArray(k, l, count);
                    }
                }
            }
        }
    }
    return spiral;
}

int[,] spiralArray = new int[m, n];
spiralArray = FillArray(0, 0, 0);

void Print(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("----------------------");
}
Console.WriteLine("");
Console.WriteLine("Массив " + m + " x " + n + " заполненный спирально числами от 1 до " + m * n);
Console.WriteLine("----------------------");
Print(spiralArray);