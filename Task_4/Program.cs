Console.Write("Введите первое число ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число ");
int userNumberB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число ");
int userNumberC = int.Parse(Console.ReadLine() ?? "");
int max = userNumberA;
if ((max < userNumberB) & (userNumberB > userNumberC))
{
    max = userNumberB;
}
else
{
    if (max < userNumberC)

        max = userNumberC;
}
Console.WriteLine($"{max} максимальное из трех чисел");