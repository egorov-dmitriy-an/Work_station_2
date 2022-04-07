// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями
// и единицами. Игрок может ходить только по полям, заполненным единицами.
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
// (эти поля требуется принудительно задать равными единице).

Random rand = new Random();
int[,] array01 = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++) array01[i, j] = rand.Next(0, 2);
}

array01[0, 0] = 1;
array01[4, 4] = 1;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array01[i, j] + "  ");
    }
    Console.WriteLine("");
}


bool Left(int i, int j, int[,] curArray)
{
    if (j - 1 < 0) return false;
    if (curArray[i, j - 1] == 0) return false;
    else return true; 
}
bool Right(int i, int j, int[,] curArray)
{
    if (j + 1 > curArray.GetLength(1)) return false;
    if (curArray[i, j + 1] == 0) return false;
    else return true;
}
bool Up(int i, int j, int[,] curArray)
{
    if (i - 1 < 0) return false;
    if (curArray[i - 1, j] == 0) return false;
    else return true;
}
bool Down(int i, int j, int[,] curArray)
{
    if (i + 1 > curArray.GetLength(0)) return false;
    if (curArray[i + 1, j] == 0) return false;
    else return true;
}

int mod = 0;
void WayHome(int k, int l, int[,] methodArray)
{
    while (k != 4 & l != 4)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Left(i, j, methodArray) == true)
                {
                    k = i;
                    l = j;
                    if (i == 0 & j == 0) mod++;
                    WayHome(k, l, methodArray);
                }
                else if (Up(i, j, methodArray) == true)
                {
                    k = i;
                    l = j;
                    if (i == 0 & j == 0) mod++;
                    WayHome(k, l, methodArray);
                }
                else if (Right(i, j, methodArray) == true)
                {
                    k = i;
                    l = j;
                    if (i == 0 & j == 0) mod++;
                    WayHome(k, l, methodArray);
                }
                else if (Down(i, j, methodArray) == true)
                {
                    k = i;
                    l = j;
                    if (i == 0 & j == 0) mod++;
                    WayHome(k, l, methodArray);
                }
                else Console.WriteLine("Из точки [0, 0] в точку [4, 4] пкти нет");
            }
        }
    }

    if (mod == 2) Console.WriteLine("Из точки [0, 0] в точку [4, 4] пути нет");
    else if (k == 4 & l == 4) Console.WriteLine("Из точки [0, 0] в точку [4, 4] путь есть");
}
int m = 0;
int n = 0;

WayHome(m, n, array01);
