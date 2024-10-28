//0 (or below) - Freezing
//from 0 to 5 - Cold
//from 5 to 10 - Chilly
//from 10 to 15 - Cool
//from 15 to 28 - Warm
//above 28 - boiling hot

Console.WriteLine("Enter the temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 0)
{
    Console.WriteLine("Freezing");
}
else if (temp > 0 && temp >= 5)
{
    Console.WriteLine("Cold");
}
else if (temp > 5 && temp >= 10)
{
    Console.WriteLine("Chilly");
}
else if (temp > 10 && temp > 15)
{
    Console.WriteLine("Cool");
}
else if (temp > 15 && temp > 28)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Boiling hot");
}