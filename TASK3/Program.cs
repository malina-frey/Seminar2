/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от 
деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите два числа");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber % SecondNumber == 0)
{
    Console.WriteLine("  кратно");
}
else
{
    Console.WriteLine("не кратно, остаток " + FirstNumber % SecondNumber);
}