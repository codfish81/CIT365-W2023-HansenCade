using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string myName, myLocation;
        Console.WriteLine("Enter First Name: ");
        myName = Console.ReadLine();
        Console.WriteLine("Enter your location: ");
        myLocation = Console.ReadLine();

        Console.WriteLine("My name is " + myName + ", I am from " + myLocation);

        var currentDate = DateTime.Now;
        Console.WriteLine(currentDate.ToShortDateString());

        var daysUntilChristmas = new DateTime(currentDate.Year, 12, 25) - currentDate;
        Console.WriteLine("Days until Christmas " + daysUntilChristmas);

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Enter width: ");
        widthString= Console.ReadLine();
        width= double.Parse(widthString);

        Console.WriteLine("Enter height: ");
        heightString= Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");

        Console.ReadKey();
    }
}