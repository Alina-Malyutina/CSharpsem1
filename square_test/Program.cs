Console.WriteLine("Thie programm compares two numbers and check is first number square of second or not. ");

Console.Write("Enter first number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int square = num2 * num2;

if(num1 == square)
{
    Console.WriteLine($"{num1} is square for {num2}");
}
else
{
    Console.WriteLine($"{num1} is not square for {num2}");
}
Console.WriteLine("Thanks for using my program <3");