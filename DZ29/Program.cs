int[] col = new int[8];
Console.WriteLine("Введи цеферки");
for (int index = 0; index <8; index++)
    {
        col[index] = Convert.ToInt32(Console.ReadLine()); //8 длина массива
    }
    Console.Write("["+col[0]+",");
for (int index = 1; index <7; index++)
    {
        Console.Write(col[index]+",");
    }
    Console.Write(col[7]+"]");
