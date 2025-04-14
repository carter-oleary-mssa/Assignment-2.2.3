
abstract class Shape
{
    private string id;
    private string name;
    private string color;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name { get { return name; }   set { name = value; } }
    public string Color { get { return color; } set { color = value; } }

    public Shape(string id, string name, string color)
    {
        this.id = id;
        this.name = name;
        this.color = color;
    }

    public decimal CalculateArea()
    {
        return 0;
    }

}
