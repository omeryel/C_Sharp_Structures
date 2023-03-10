

Person person = new Person()
{
    Name = "Test",
    Age = 10,
};


// x will be Test
// y will be 10
var (x, y) = person;


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }   
    
    // Return type must be void
    // Method name must be Deconstruct
    // Parameters must be used with out keyword
    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}