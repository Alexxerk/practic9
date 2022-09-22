//Показать натуральные числа от M до N, N и M заданы
int m = 12; 
int n = 21;

int SequensMN(int one)
{
        return (one == 1 ? 1 : SequensMN(1) + (one - 1));
}

for (int i = m; i <= n; i++)
{
    Console.Write(SequensMN(i) + " ");
}

Console.WriteLine();

int SequensNM(int two)
{
        return (two == 1 ? 1 : SequensNM(1) + (two - 1));
}

for (int i = n; i >= m; i--)
{
    Console.Write(SequensNM(i) + " ");
}





