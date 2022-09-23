//Написать программу возведения числа А в целую стень B

int Ascension(int number, int stepen) 
{
    if (stepen == 1) return number;
    else if (stepen == 0) return 1;
    else return number * Ascension(number, --stepen);
}

Console.WriteLine(Ascension(3, 2));
