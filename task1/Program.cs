//Показать натуральные числа от N до 1, N задано

int n = 5;

int SequensFor(int n)
{
    if(n == 1) return 1;
    else return (n + 1) - SequensFor(n - (n-1));
}

for (int i = n; i >= 1; i--)
{
    Console.Write(SequensFor(i) + " ");
}

