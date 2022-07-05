int n, n1, sum =1;
Console.WriteLine("Введите число A: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
n1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n1; i++)
{
    sum = sum * n;
}

Console.WriteLine(sum);