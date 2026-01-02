namespace basic_application.OOP;

class Car // The blueprint
{
    // Field or Attribute
    public string? Color;
    public int Speed;

    // Method or Behavior
    public void Drive()
    {
        Console.WriteLine($"The {Color} car is driving at {Speed} mph.");
    }
}
