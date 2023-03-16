Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine()!;

if(num.Length == 3)
{
    Console.WriteLine($"{num} -> {num[1]}");
}
else
{
    Console.WriteLine("Введено не трехзначное число.");
}
