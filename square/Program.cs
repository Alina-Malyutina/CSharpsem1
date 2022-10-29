Console.Clear(); // CLEAR TERMINAL
Console.WriteLine("This programm read your number and squares it.");
Console.WriteLine("Enter your number. It must be an integer");
int number = Convert.ToInt32(Console.ReadLine()); // read number

 int square = number * number; //calculation

Console.WriteLine($"Square of {number} is {square}"); // output

Console.WriteLine("Thanks for using my program <3"); //Thanks