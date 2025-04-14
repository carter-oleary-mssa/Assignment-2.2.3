Console.WriteLine("--------------- SHAPE GENERATOR ---------------");
Console.Write("Enter a shape id: ");
string id = Console.ReadLine();
Console.Write("Enter a shape name: ");
string name = Console.ReadLine();
Console.Write("Enter a shape color: ");
string color = Console.ReadLine();
Console.WriteLine("Please select what shape to create: ");
Console.WriteLine("\tc: Circle");
Console.Write("\ts: Square\n\t");
switch (Console.ReadLine().ToLower())
{
	case "c":
        Console.Write("Enter a radius: ");
		decimal radius = Convert.ToDecimal(Console.ReadLine());
		Circle c = new Circle(id, name, color, radius);
        Console.WriteLine($"The area of the circle {c.Name} is {c.CalculateArea()}");
		break;
	case "s":
        Console.Write("Enter a side length: ");
        decimal side = Convert.ToDecimal(Console.ReadLine());
        Square s = new Square(id, name, color, side);
        Console.WriteLine($"The area of the square {s.Name} is {s.CalculateArea()}");
        break;
    default:
		break;
}