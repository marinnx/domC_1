// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели: ");
int nday = int.Parse(Console.ReadLine());
if (nday == 6 || nday == 7)
{
    Console.WriteLine($"{nday} -> да");
}
else
{
    Console.WriteLine($"{nday} -> нет");
}