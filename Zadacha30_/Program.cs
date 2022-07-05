Console.WriteLine("Загадай число от 1 до 100");
int n_first = 0, n_last = 100, mid = 0;
while (n_first <= n_last)
{
    mid = (n_first + n_last) / 2;
    Console.WriteLine("Число больше {0}?", mid);
    string? ans = Console.ReadLine();
    if (ans == "yes")
    {
        n_first = mid;
    }
    else
    {
        n_last = mid;
    }
    if (n_last - n_first == 1)
        break;
    
}


Console.WriteLine(mid);

//находим число в промежутке от 1 до 100