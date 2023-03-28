Day ();

void Day ()
{
System.Console.WriteLine("Введите день недели:");
int N = int.Parse(Console.ReadLine());

if (7 >= N & N >= 1)
{
    if( N == 6 | N == 7)
    {
    System.Console.WriteLine("Выходной день!");
    }
    else
    {
    System.Console.WriteLine("Рабочий день!");
    }
}

else 
{
    System.Console.WriteLine("Неверно введен день недели!");

}
}