Console.Write("Введите целое число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");
if (userNumber%2 == 0)
{
    Console.WriteLine($"{userNumber} четное число");
}
else
{
    Console.WriteLine($"{userNumber} нечетное число");
}