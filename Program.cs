using Object_Lab;
using StaticLecture;
string answer;
bool repeat = true;
Circle myCircle;

Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine("Please enter a radius: ");
myCircle = new Circle(Validator.GetInputInt());  //extra credit
/*
while (true)
{
    try
    {
        Console.Write("Enter radius: ");
        myCircle = new Circle(int.Parse(Console.ReadLine()));
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}
*/



while (repeat == true)
{
    Console.WriteLine($"\nDiameter: {myCircle.CalculateDiameter()}");
    Console.WriteLine($"Circumference: {myCircle.CalculateCircumfrence()}");
    Console.WriteLine($"Area: {myCircle.CalculateArea()}");
    Console.Write("Should the circle grow? (y/n): ");



    answer = Console.ReadLine().ToLower();

    if (answer == "y")
    {
        myCircle.Grow();
        Console.WriteLine("The circle is magically growing!");
    }
    else
    {
        Console.WriteLine($"\nGoodbye. The circle's final radius is {myCircle.GetRadius()}");
        repeat = false;
        
    }
}