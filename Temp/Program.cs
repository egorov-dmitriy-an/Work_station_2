DateTime date1 = DateTime.Now;
Console.WriteLine(date1.ToString("T"));
string time = Convert.ToString(date1);
for (int i = 11; i < 19; i++) Console.Write(time[i]);
Console.WriteLine("");
void Print(char[,] timearray)// Печать массива
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(timearray[i, j]);
        }
        Console.WriteLine("");
    }
}

char [,] null_array = new char[5,3] {{'*', '*', '*'},{'*', ' ', '*'}, {'*', ' ', '*'}, {'*', ' ', '*'}, {'*', '*', '*'}};
char [,] one_array = new char[5,3] {{' ', ' ', '*'},{' ', '*', '*'}, {'*', ' ', '*'}, {' ', ' ', '*'}, {' ', ' ', '*'}};
char [,] two_array = new char[5,3] {{'*', '*', '*'},{' ', ' ', '*'}, {' ', ' ', '*'}, {' ', '*', ' '}, {'*', '*', '*'}};
char [,] three_array = new char[5,3] {{'*', '*', '*'},{' ', ' ', '*'}, {'*', '*', '*'}, {' ', ' ', '*'}, {'*', '*', '*'}};
char [,] four_array = new char[5,3] {{'*', ' ', '*'},{'*', ' ', '*'}, {'*', '*', '*'}, {' ', ' ', '*'}, {' ', ' ', '*'}};
char [,] five_array = new char[5,3] {{'*', '*', '*'},{'*', ' ', ' '}, {'*', '*', '*'}, {' ', ' ', '*'}, {'*', '*', '*'}};
char [,] six_array = new char[5,3] {{'*', '*', '*'},{'*', ' ', ' '}, {'*', '*', '*'}, {'*', ' ', '*'}, {'*', '*', '*'}};
char [,] seven_array = new char[5,3] {{'*', '*', '*'},{' ', ' ', '*'}, {' ', '*', ' '}, {'*', ' ', ' '}, {'*', ' ', ' '}};
char [,] eight_array = new char[5,3] {{'*', '*', '*'},{'*', ' ', '*'}, {'*', '*', '*'}, {'*', ' ', '*'}, {'*', '*', '*'}};
char [,] nine_array = new char[5,3] {{'*', '*', '*'},{'*', ' ', '*'}, {'*', '*', '*'}, {' ', ' ', '*'}, {'*', '*', '*'}};

Print(null_array);
Print(one_array);
Print(two_array);
Print(three_array);
Print(four_array);
Print(five_array);
Print(six_array);
Print(seven_array);
Print(eight_array);
Print(nine_array);

