class Square : Shape
{
    private decimal sideLength;

    public decimal SideLength { get { return sideLength; } set { sideLength = value; } }

    public Square(string id, string name, string color, decimal side) : base(id, name, color)
    {
        sideLength = side;
    }

    public decimal CalculateArea()
    {
        return sideLength * sideLength;
    }
}

