Console.WriteLine("Welcome to the room calculator");
//getting user input
Console.WriteLine("Please enter a length.");
float length = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter a width.");
float width = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter a height.");
float height = float.Parse(Console.ReadLine());
//calculations
float area = width * length;
float perimeter = 2 * (length + width);
float volume = length * width * height;
float surfaceArea = 2 * ((width * length)+(height*length)+(height*width));
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {surfaceArea}");
//room size
if(area <= 250)
{
    Console.WriteLine("This room is small.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This room is medium");
}
else
{
    Console.WriteLine("This room is large");
}