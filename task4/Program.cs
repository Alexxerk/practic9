//Найти сумму цифр числа

int x = 1234;

int Sum(int num)
{
    if (num < 10) return num;
    else return num % 10 + Sum(num / 10);
}

Console.WriteLine(Sum(x));
