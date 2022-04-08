// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями
// и единицами. Игрок может ходить только по полям, заполненным единицами.
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
// (эти поля требуется принудительно задать равными единице).

Random rand = new Random();
int[,] array01 = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array01[i, j] = rand.Next(0, 2);
    }
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
    if (curArray[i, j - 1] == 1) return true;
    else return false; 
}
bool Right(int i, int j, int[,] curArray)
{
    if (j + 1 > curArray.GetLength(1)) return false;
    if (curArray[i, j + 1] == 1) return true;
    else return false;
}
bool Up(int i, int j, int[,] curArray)
{
    if (i - 1 < 0) return false;
    if (curArray[i - 1, j] == 1) return true;
    else return false;
}
bool Down(int i, int j, int[,] curArray)
{
    if (i + 1 > curArray.GetLength(0)) return false;
    if (curArray[i + 1, j] == 1) return true;
    else return false;
}

int mod = 0;
string WayHome(int k, int l, int[,] methodArray)
{
    while (mod != 2)
    {
                Console.WriteLine("Старт k = " + k + ", l = " + l);
                if (Left(k, l, methodArray) == true)
                {
                    l = l - 1;
                    Console.WriteLine("Идем влево k = " + k + " l = " + l);
                    if (k == 0 & l == 0)
                    {
                        mod++;
                        Console.WriteLine("Прошел через 0;0 раз - " + mod);
                    }
                    Thread.Sleep(3000);
                    WayHome(k, l, methodArray);
                }
                else if (Up(k, l, methodArray) == true)
                {
                    k = k - 1;
                    Console.WriteLine("Идем вверх k = " + k + " l = " + l);
                    if (k == 0 & l == 0)
                    {
                        mod++;
                        Console.WriteLine("Прошел через 0;0 раз - " + mod);
                    }
                    Thread.Sleep(3000);
                    WayHome(k, l, methodArray);
                }
                else if (Right(k, l, methodArray) == true)
                {
                    l = l + 1;
                    if (k == 0 & 1 == 0)
                     Console.WriteLine("Идем вправо k = " + k + " l = " + l);
                    if (k == 0 & l == 0)
                    {
                        mod++;
                        Console.WriteLine("Прошел через 0;0 раз - " + mod);
                    }
                    Thread.Sleep(3000);
                    WayHome(k, l, methodArray);
                }
                else if (Down(k, l, methodArray) == true)
                {
                    k = k + 1;
                    if (k == 0 & l == 0)
                    {
                        mod++;
                        Console.WriteLine("Прошел через 0;0 раз - " + mod);
                    }
                    Console.WriteLine("Идем вниз k = " + k + " l = " + l);
                    Thread.Sleep(3000);
                    WayHome(k, l, methodArray);
                }
                else 
                {
                    mod = 2;
                    Console.WriteLine("Ходов нет");
                }    
    }
    string result = string.Empty;
    if (mod == 3) result = "Из точки [0, 0] нет ходов вообще";
    if (k == 4 & l == 4) result = "Из точки [0, 0] в точку [4, 4] путь есть)))";
    return result;
}
int m = 0;
int n = 0;
Console.WriteLine(WayHome(m, n, array01));
