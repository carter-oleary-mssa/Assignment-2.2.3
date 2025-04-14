class Circle : Shape
{
    private decimal radius;

    public decimal Radius { get { return radius; } set { radius = value; } }

    public Circle(string id, string name, string color, decimal r) : base(id, name, color)
    {
        this.radius = r;      
    }

    public decimal CalculateArea()
    {
        return Convert.ToDecimal(Math.PI) * radius * radius;
    }
}

