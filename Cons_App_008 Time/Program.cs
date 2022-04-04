
    void Print(char[,] timearray, int index)// Печать массива
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.SetCursorPosition(j + index * 5, i + 3);
                Console.Write(timearray[i, j]);
            }
            Console.WriteLine("");
        }
    }

    char[,] null_array = new char[5, 3] { { '0', '0', '0' }, { '0', ' ', '0' }, { '0', ' ', '0' }, { '0', ' ', '0' }, { '0', '0', '0' } };
    char[,] one_array = new char[5, 3] { { ' ', ' ', '0' }, { ' ', '0', '0' }, { '0', ' ', '0' }, { ' ', ' ', '0' }, { ' ', ' ', '0' } };
    char[,] two_array = new char[5, 3] { { '0', '0', '0' }, { ' ', ' ', '0' }, { ' ', ' ', '0' }, { ' ', '0', ' ' }, { '0', '0', '0' } };
    char[,] three_array = new char[5, 3] { { '0', '0', '0' }, { ' ', ' ', '0' }, { '0', '0', '0' }, { ' ', ' ', '0' }, { '0', '0', '0' } };
    char[,] four_array = new char[5, 3] { { '0', ' ', '0' }, { '0', ' ', '0' }, { '0', '0', '0' }, { ' ', ' ', '0' }, { ' ', ' ', '0' } };
    char[,] five_array = new char[5, 3] { { '0', '0', '0' }, { '0', ' ', ' ' }, { '0', '0', '0' }, { ' ', ' ', '0' }, { '0', '0', '0' } };
    char[,] six_array = new char[5, 3] { { '0', '0', '0' }, { '0', ' ', ' ' }, { '0', '0', '0' }, { '0', ' ', '0' }, { '0', '0', '0' } };
    char[,] seven_array = new char[5, 3] { { '0', '0', '0' }, { ' ', ' ', '0' }, { ' ', '0', ' ' }, { '0', ' ', ' ' }, { '0', ' ', ' ' } };
    char[,] eight_array = new char[5, 3] { { '0', '0', '0' }, { '0', ' ', '0' }, { '0', '0', '0' }, { '0', ' ', '0' }, { '0', '0', '0' } };
    char[,] nine_array = new char[5, 3] { { '0', '0', '0' }, { '0', ' ', '0' }, { '0', '0', '0' }, { ' ', ' ', '0' }, { '0', '0', '0' } };
    char[,] point_array = new char[5, 3] { { ' ', ' ', ' ' }, { ' ', '0', ' ' }, { ' ', ' ', ' ' }, { ' ', '0', ' ' }, { ' ', ' ', ' ' } };

    void Time()
{
    DateTime date1 = DateTime.Now;
    string time = Convert.ToString(date1);

    int index_number = 0;
    for (int i = 11; i < 19; i++)
    {

        if (time[i] == '0') Print(null_array, index_number);
        if (time[i] == '1') Print(one_array, index_number);
        if (time[i] == '2') Print(two_array, index_number);
        if (time[i] == '3') Print(three_array, index_number);
        if (time[i] == '4') Print(four_array, index_number);
        if (time[i] == '5') Print(five_array, index_number);
        if (time[i] == '6') Print(six_array, index_number);
        if (time[i] == '7') Print(seven_array, index_number);
        if (time[i] == '8') Print(eight_array, index_number);
        if (time[i] == '9') Print(nine_array, index_number);
        if (time[i] == ':') Print(point_array, index_number);
        index_number++;
        Console.WriteLine("");
        Console.WriteLine("");

    }
        
        TimeSpan interval = new TimeSpan(0, 0, 1);
        TimeSpan interval2 = date1 - DateTime.Now;
        
        Thread.Sleep(interval - interval2);
        Console.Clear();
        Time();
}
Time();


