Console.WriteLine("Введите трехзначное число:");
int N = int.Parse(Console.ReadLine());

if ( 1000 > N && N > 99)
{
    Console.WriteLine($"Вторая цифра числа равна {Two(N)}");
}

else 
{
    Console.WriteLine($"Число {N} не трехзначное!!!");
}

int Two (int N)
{
    N = N/10;
    return N = N%10;
}