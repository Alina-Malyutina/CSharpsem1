Console.WriteLine("This programm show all integer numbers between [-entered number] and [entered number]");
Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());

int size = number * 2 + 1;

number = number * (-1);

for(int i = 0; i < size; i++)
{
    Console.Write($"{number}, ");
    number++;
}
