Console.Write("Введите трехзначное число: ");

// строковый метод
// string num = Console.ReadLine()!;

// if(num.Length == 3)
// {
//     Console.WriteLine($"{num} -> {num[1]}");
// }
// else
// {
//     Console.WriteLine("Введено не трехзначное число.");
// }

// математический метод
int num = Convert.ToInt32(Console.ReadLine());
int second = 0;
if (num >= 100 && num <= 999)
{
    second = num / 10 % 10;
    Console.WriteLine($"{num} -> {second}");
}
else
{
    Console.WriteLine("Введено не трехзначное число.");
}