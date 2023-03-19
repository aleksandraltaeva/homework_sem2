Console.Write("Введите число: ");
//строковый метод
// string num = Console.ReadLine()!;

// if (num.Length < 3)
// {
//     Console.Write($"В {num} третьей цифры нет.");
// }
// else
// {
//     Console.Write($"{num} -> {num[2]}");
// }

//математический метод
int num1 = Convert.ToInt32(Console.ReadLine());

int num = num1;

if (num >= 100)
{
    while (num > 999)
    {
        num /= 10;
    }
     Console.Write($"{num1} -> {num % 10}");
}
else
{
    Console.Write($"В {num1} третьей цифры нет.");
}