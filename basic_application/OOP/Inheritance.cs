namespace basic_application.OOP.Inheritance;

class BaseClass
{
    // Base class members
}

class DerivedClass : BaseClass
{
    // Derived class members
}

// Single Inheritance
class Parent
{
    public void Show()
    {
        Console.WriteLine("This is the parent class.");
    }
}

class Child01 : Parent
{
    public void ShowChild01()
    {
        Console.WriteLine("This is the child 01 class.");
    }
}

class Child02 : Parent
{
    public void ShowChild02()
    {
        Console.WriteLine("This is the child 02 class.");
    }
}

// Multilevel Inheritance
class GrandFather
{
    public void Display()
    {
        Console.WriteLine("This is the grand father class.");
    }
}

class Father : GrandFather
{
    public void DisplayFather()
    {
        Console.WriteLine("This is the father class.");
    }
}

class Son : Father
{
    public void DisplaySon()
    {
        Console.WriteLine("This is the child class.");
    }
}
