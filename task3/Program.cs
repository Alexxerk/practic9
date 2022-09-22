//Найти сумму элементов от M до N, N и M заданы

int n = 10;
int m = 16;

int SumMN(int x)
{
    if (x == m) return x;
    else return x + SumMN(x + 1);
}

Console.WriteLine(SumMN(n));




