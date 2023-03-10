



MyClass m1 = new MyClass() { MyProperty = 5 };
MyClass m2 = new MyClass() { MyProperty = 5 };

MyRecord r1 = new MyRecord() { MyProperty = 5, MyProperty1 = 10 };
MyRecord r2 = new MyRecord() { MyProperty = 5, MyProperty1 = 10 };


Console.WriteLine(m1.Equals(m2)); // False

Console.WriteLine(r1.Equals(r2)); // True


// Record properties are immutable so in order to update one or more properties value new record must be created update value.
// That is possible with "with" keyword. 
MyRecord r3 = r1 with { MyProperty1 = 15 };

Console.WriteLine(r3.MyProperty1); // 15

//Records are intended  for supporting immutable properties. Records are data-centric reference type.
record MyRecord
{
    public int MyProperty { get; init; }
    public int MyProperty1 { get; init; }
}
class MyClass
{
    public int MyProperty { get; init; }
}

