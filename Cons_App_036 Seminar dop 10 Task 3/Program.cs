// Задача 3. Дан массив, состоящий из случайных целых чисел.
// Дано число M. Выведите случайное подмножество массива,
// сумма элементов в котором не превосходит M.
// {11, 52, 36, 8, 19}, M = 50 >> 11, 19, 8
// {11, 52, 36, 8, 19}, M = 50 >> 36, 8

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] array = new int[length];
Console.Write("");

for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(0, 100);
    Console.Write(array[i] + ", ");
}
Console.WriteLine("");

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int summa = 0;
int leng = rand.Next(1, length + 1);
List<int> result = new List<int>();

if (summa < m)
{
    for (int i = 0; i < leng; i++)
    {

    }
}
