Console.WriteLine("Enter current temperature:");
int currentTemp = int32.Parse(Console.ReadLine());

if (currentTemp <= 0)
{
    Console.WriteLine("It's freezing.");
}

else if (currentTemp > 0 && currentTemp < 5)
{
    Console.WriteLine("It's cold.");
}

else if (currentTemp >= 5 && currentTemp < 10)
{
    Console.WriteLine("It's chilly.");
}

else if (currentTemp >= 10 && currentTemp < 15)
{
    Console.WriteLine("It's cool.");
}

else if (currentTemp >= 15 && currentTemp < 28)
{
    Console.WriteLine("It's warm.");
}

else
{
    Console.WriteLine("It's hot.");
}