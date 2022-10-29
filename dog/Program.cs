int VFriend1 = 1, VFriend2 = 2, Vdog = 4,
    S = 10000,
    friend = 2,
    count = 0,
    T = 0;
while(S > 10)
{
    if (friend == 1)
    {
        T = S / (VFriend1 + Vdog);
        friend = 2;
    }
    
    if (friend == 2)
    {
        T = S / (VFriend2 + Vdog);
        friend = 1;
    }
S = S - (VFriend1 + VFriend2)*T;
count = count++;
}
Console.Write("Dog run ");
Console.Write (count);
Console.WriteLine(" times");
