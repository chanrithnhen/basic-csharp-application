using basic_application.OOP.Inheritance;
namespace basic_application.OOP.Result;

class Result
{
    public void Run()
    {
        Object obj = new Object();
        obj.Result();

        // ===== Inheritance ===== //
        Child01 child01 = new Child01();
        child01.Show();
        child01.ShowChild01();

        Child02 child02 = new Child02();
        child02.Show();
        child02.ShowChild02();

        Son son = new Son();
        son.Display();
        son.DisplayFather();
        son.DisplaySon();

        // ===== Encapsulation ===== //
    }
}
