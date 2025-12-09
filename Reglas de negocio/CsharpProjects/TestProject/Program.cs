Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 0)
{
    if(daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your suscription exprires within a day/nRenew now and save {discountPercentage}%");
    } else if ()
    {
        
    }
    Console.WriteLine($"Your subscription has expired.");
}