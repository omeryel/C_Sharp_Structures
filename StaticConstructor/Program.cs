
new MyClass();
new MyClass();



// For first instance of class, firstly static constructor is called then constructor is called.
// While creating next intances of class , static constructor is not called.
class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor");
    }

    static MyClass()
    {
        Console.WriteLine("Static Constructor");
    }
}