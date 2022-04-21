string way = "C:/Users/Владислав/Desktop/2. Пакет Digital-master/0. Home_work/2. Begining_2/Cons_App_029 Directory";
DirectoryInfo di = new DirectoryInfo(way);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i<fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}