Console.Write("Введите первое число ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");
if (userNumberA > userNumberB)
{
    Console.WriteLine($"{userNumberA} больше {userNumberB}");
}
else
{
    Console.WriteLine($"{userNumberB} больше {userNumberA}");
}