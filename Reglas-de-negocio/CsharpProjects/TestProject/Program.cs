Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration <= 10)
{
    if(daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your suscription exprires within a day \n Renew now and save {discountPercentage}%");
    } else if ((daysUntilExpiration > 1) && (daysUntilExpiration <= 5))
    {
        discountPercentage = 10;
        Console.WriteLine($"Your suscription exprires in {daysUntilExpiration} days \n Renew now and save {discountPercentage}%.");
    }
    else if (daysUntilExpiration < 1)
    {
        Console.WriteLine($"Your subscription has expired.");
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}