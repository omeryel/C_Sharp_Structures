


MyRecord myRecord = new MyRecord("testName", "testSurname");
var (x, y) = myRecord;



// Positional Record provides short way to use constructor and desconstructor
// With this method signature 2 parameter constructor and deconstructor called
// To overload constructor, "this" method must be called

record MyRecord(string Name, string Surname)
{
    MyRecord() : this("name", "surname")
    {

    }

    MyRecord(string Address): this()
    {

    }

}