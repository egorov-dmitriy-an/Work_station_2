
           
                int summa = 0;
                int multi = 1;
                int count = 0;
                while (number > 0)
                {
                    Console.Write(number + "   ");
                    
                    count = number % 10;
                    summa = summa + count;
                    multi = multi * count;
                    Console.Write("ост = " + count + "   " + multi);
                    number = number / 10;
                    Console.Write("  новое -> " + number);
                }
                Console.WriteLine("   Сумма - " + summa + " Произведение - " + multi);
                if (summa > multi) return true;
                else return false;
            }

            List<int> numbList = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (SummaElement(array34[i, j]) == true)
                    {
                        numbList.Add(array34[i, j]);
                    }
                }
            }
            int[] currArray = numbList.ToArray();
            Console.WriteLine("");
            Console.WriteLine("Массив чисел, сумма цифр которых больше их произведения: ");
            int count = currArray.Length;
            for (int i = 0; i < count; i++) Console.Write(currArray[i] + "  ");
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}