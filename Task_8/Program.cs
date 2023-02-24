Console.Write("Введите целое число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");
for (int i = 1; i <= userNumber; i++)
    if (i % 2 == 0)
        Console.WriteLine($"{i}");
