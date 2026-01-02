namespace basic_application.OOP;

class ClassName
{
    
}

abstract class AbstractClass
{
    public abstract void Display();
}

class Person // Class
{
    // Field
    public string? Name { get; set; }
    public int Age { get; set; }

    // Method
    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
