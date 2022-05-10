Console.WriteLine();
Console.WriteLine("------------Контрольная работа---------------");
Console.Write("Введите количество строк исходного массива: "); // Зададим количество элементов массива.
int length = Convert.ToInt32(Console.ReadLine());

string[] textArray = new string[length]; // Инициализируем массив и заполним его.
for (int i = 0; i < length; i++)
{
    Console.Write("Строка с индексом " + i + ": ");
    textArray[i] = Console.ReadLine();
}

Console.WriteLine("---------------------------------------------");

Console.Write("Исходный массив: ");
Console.Write("[");
for (int l = 0; l < length; l++)
{
    Console.Write("'" + textArray[l] + "'");
    if (l != length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

int newLength = 0; // Определим количество строк, длина которых менее или равна 3.
for (int j = 0; j < length; j++)
{
    if (textArray[j].Length <= 3) newLength++;
}

Console.WriteLine("---------------------------------------------");

Console.Write("Новый массив: ");
int count = 0;
string[] newTextArray = new string[newLength];
Console.Write("[");
for (int k = 0; k < length; k++)
{
    if (textArray[k].Length <= 3)
    {
        newTextArray[count] = textArray[k];
        Console.Write("'" + newTextArray[count]+"'");
        if (count != newLength - 1)
        {
            Console.Write(", ");
        }
        count++;
    }
}
Console.WriteLine("]");
Console.WriteLine("------------------Конец----------------------");
Console.WriteLine();
