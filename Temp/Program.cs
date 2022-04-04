void Time()
{
    DateTime date1 = DateTime.Now;
    string time = Convert.ToString(date1);
    Console.WriteLine("");
    for (int i = 11; i < 19; i++) Console.Write(time[i]);
    Console.WriteLine("");
    Console.WriteLine("");
    
    Thread.Sleep(1000);
    Console.Clear();
    Time();
}
Time();
