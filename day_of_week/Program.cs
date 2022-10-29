Console.WriteLine("This programm read day of week's number and tell that day of week is it.");
Console.WriteLine("Enter number of day at week. Please, use european system - Monday is first day, Sunday is last. ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 8 && number > 0)
{
    if(number == 1)
        {
           Console.WriteLine($"If you write {number}, you mean Monday!");
        }

    if(number == 2)
        {
            Console.WriteLine($"If you write {number}, you mean Tuesday!");
        }

    if(number == 3)
        {
            Console.WriteLine($"If you write {number}, you mean Wednesday!");
        }

    if(number == 4)
        {
            Console.WriteLine($"If you write {number}, you mean Thursday!");
        }

    if(number == 5)
        {
            Console.WriteLine($"If you write {number}, you mean Friday!");
        }

    if(number == 6)
        {
            Console.WriteLine($"If you write {number}, you mean Saturday!");
        }
    if(number == 7)
        {
            Console.WriteLine($"If you write {number}, you mean Sunday!");
        }
}
else
{
    Console.WriteLine("In week we have only 7 days!");
}
Console.WriteLine("Thanks for using my program <3");