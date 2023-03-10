using System.Security.Cryptography.X509Certificates;

int total = 100;
string color = "red";
#region type01
//Checks color value if it is in options if not it goes default option

switch (color)
{
    case "red":
        Console.WriteLine($"Color : {color}");
        break;
    case "white":
        Console.WriteLine($"Color : {color}");
        break;
    default:
        Console.WriteLine($"Undefined Color");
        break;
}

#endregion

#region type02 /w when
// Supports addition conditions with when keyword
switch (color)
{
    case "red" when (total > 50):
        Console.WriteLine($"Color : {color}");
        break;
    case "white" when( total < 120 && DateTime.Now < DateTime.Now.AddDays(1)):
        Console.WriteLine($"Color : {color}");
        break;
    default:
        Console.WriteLine($"Undefined Color");
        break;
}

#endregion

#region type03 /w goto
// Redirect to another case with goto keyword
switch (color)
{
    case "red":
        Console.WriteLine($"Color : {color}");
        break;
    case "white" when (total < 120 && DateTime.Now < DateTime.Now.AddDays(1)):
        Console.WriteLine($"Color : {color}");
        break;
    case "brown":
        goto case "red";
    default:
        Console.WriteLine($"Undefined Color");
        break;
}

#endregion

#region type04
// Short notation 
Console.WriteLine(color switch
{
    "red" => $"Color {color}",
    "white" => $"Color {color}",
    var x => "Undefined Color" // default case
});

#endregion

#region type05
// Short notation /w when keyword
Console.WriteLine(color switch
{
    "red" when total > 30 && DateTime.Now > DateTime.Now.AddHours(-1) => $"Color {color}",
    "white" => $"Color {color}",
    var x when x.StartsWith("bro") => "It starts with 'bro'",
    var x => "Undefined Color"
});

#endregion

#region type06 /w tuple
// Parameter as tuple 
switch (color, total)
{
    case ("red", 50):
        Console.WriteLine( $"Color {color}, total {total}");
        break;
    case ("white", 120):
        Console.WriteLine($"Color {color}, total {total}");
        break;
    default:
        break;
}

#endregion

#region type07 /w tuple
// Short notation /w tuple parameter
Console.WriteLine((color, total) switch
{
    ("red",  100) => $"Color {color}, total {total}",
    ("white", 120) => $"Color {color}, total {total}",
    (_, _) => "Undefined Color" // default case
});
#endregion

#region type08
//Short Notation /w logical operations
Console.WriteLine( total switch
{
    < 120  => $"Total {total} is not bigger than 120",
    > 120  => $"Total {total} is bigger than 120",
    _ => $"Total {total} is 120"
});

#endregion