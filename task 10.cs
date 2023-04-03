Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100 && number >= 1000);
{
    Console.WriteLine("Не трехзначное число");
}
 int secondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра в трехзначном числе = {secondDigit}");