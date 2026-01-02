namespace basic_application.OOP;

class Run // The instance
{
    public void Show()
    {
        // Creating an object (instance) of the Car class
        Car myCar01 = new Car();
        myCar01.Color = "Red";
        myCar01.Speed = 60;
        myCar01.Drive(); // Output: The Red car is driving at 60 mph.

        // Creating another object from the same blueprint
        Car myCar02 = new Car();
        myCar02.Color = "Blue";
        myCar02.Speed = 75;
        myCar02.Drive(); // Output: The Blue car is driving at 75 mph.
    }
}
