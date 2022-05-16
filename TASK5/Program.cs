/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.WriteLine("Введите два числа");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if(FirstNumber * FirstNumber == SecondNumber || SecondNumber * SecondNumber == FirstNumber)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}