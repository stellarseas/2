Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{{
    Console.WriteLine("Выходной");
}
if (dayNumber < 1 && dayNumber > 7)
{
    Console.WriteLine("Не является днем недели");
}}
else
    Console.WriteLine("Рабочий день");
