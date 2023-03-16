Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 0 && num < 8)
{
    if (num == 6 || num == 7)
    {
     Console.Write($"{num} является выходным.");   
    }
    else
    {
        Console.Write($"{num} не является выходным."); 
    }
}
else 
{
    Console.Write("Такого дня недели не существует.");  
}