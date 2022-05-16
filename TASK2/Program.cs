/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
int OneNumber = randomNumber / 100;
int SecondNumber = randomNumber % 10;
int ThirdNumber = OneNumber * 10 + SecondNumber;
Console.WriteLine($"{randomNumber} -> {ThirdNumber}");