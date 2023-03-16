Console.Write("Введите число: ");
string num = Console.ReadLine()!;

if (num.Length < 3)
{
    Console.Write($"В {num} третьей цифры нет.");
}
else
{
    Console.Write($"{num} -> {num[2]}");
}