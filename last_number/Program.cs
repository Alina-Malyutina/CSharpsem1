Console.WriteLine("This program print last digit of number");
Console.WriteLine("Enter your number");

int number = Convert.ToInt32(Console.ReadLine());

int digit = number % 10;

Console.WriteLine($"Last digit of number {number} is {digit}");

Console.WriteLine("Thanks for using my program <3");