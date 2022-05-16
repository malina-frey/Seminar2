/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа. 
78 -> 8 
12-> 2 
85 -> 8
*/

int randomNumber = new Random().Next(10, 100);
int OneNumber = randomNumber / 10;
int SecondNumber = randomNumber % 10;
if (OneNumber > SecondNumber)
{
    Console.WriteLine($"{OneNumber} max {randomNumber}");
}
else
{
    Console.WriteLine($"{SecondNumber} max {randomNumber}");
}