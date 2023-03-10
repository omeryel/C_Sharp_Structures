#region type01
// Prints 10 times 

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("hello world");
}
#endregion

#region type02
// Prints 10 times , but variable was defines before for loop
int z = 0;
for (; z < 10; z++)
{
    Console.WriteLine("hello world");
}

#endregion

#region type03
// Loop variable can be defined before loop and can be changed in for loop
int x = 0;
for(x = 5; x < 10; x++)
{
    Console.WriteLine("hello world");
}

#endregion


#region type04
// Variable be initialized before for loop and it can be increase/decrease in loop

int c = 0;
for(; c < 10;)
{
    Console.WriteLine("hello world");
    c++;
}

#endregion

#region type05
// Condition does not have to depend on loop variable
string fruit = "orange";

for (int v = 0; fruit == "pear" ; v++)
{
    Console.WriteLine("hello world");
}

#endregion

#region type06
// with this notation loop will be infinite loop
//for (; ; )
//{
//    Console.WriteLine( "hello world");
//}
#endregion

#region type07
// Due to absence of condition , this for loop infinite loop
//for(int b = 0; ; b++)
//{
//    Console.WriteLine("hello world");
//}

#endregion

#region type08
// In for loop multiple variable can be defined 
for (int n= 0, m=4; n < 10 && m < 9; n++, m++)
{
    Console.WriteLine( "hello world" );
}
#endregion


