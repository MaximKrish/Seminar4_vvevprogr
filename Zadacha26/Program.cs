Console.WriteLine ("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(n > 0)
{
count ++;
    n = n / 10;
}
  
Console.WriteLine("Количество цифр равно:");
Console.WriteLine(count);

// Console.Write("ВВедите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine((int)Math.Log10(num)+1);

// Напишите программу, которая принимает на вход число и выдает количество цифр в числе