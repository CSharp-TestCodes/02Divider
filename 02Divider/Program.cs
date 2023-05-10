
for(int i =1; i<=100; i++)
{
    if (i % 15 == 0)
    {
        Console.WriteLine(i + " is divided by both 5 and 3");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i +" is divided by only 5");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " is divided by only 3");
    }
    else
    {
        Console.WriteLine(i + " is not devicible");
    }
}