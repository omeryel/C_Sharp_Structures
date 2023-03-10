using Microsoft.Extensions.Primitives;

#region type01
// Empty array is created then fills 
string[] myArr = new string[3];
myArr[0] = "pear";
myArr[1] = "orange";
myArr[2] = "kiwi";

Console.WriteLine($"type01 array");
for (int i = 0; i < myArr.Length; i++)
{
    Console.WriteLine(myArr[i]);
}
Console.WriteLine();
#endregion

#region type02
// Array initialize with data
string[] myArr2 = { "orange", "kiwi", "pear"};
Console.WriteLine($"type02 array");
for(int i = 0;i < myArr2.Length; i++)
{
    Console.WriteLine(myArr2[i]);
}
Console.WriteLine();
#endregion

#region type03
// Array initialize with new keyword and data
string[] myArr3 = new string[] { "orange", "kiwi", "pear" };
Console.WriteLine($"type03 array");
for (int i = 0; i < myArr3.Length; i++)
{
    Console.WriteLine(myArr3[i]);
}
Console.WriteLine();
#endregion

#region type04
// Array initialize with new keyword, data and array size
string[] myArr4 = new string[3] { "orange", "kiwi", "pear" };
Console.WriteLine("type04 array");
for (int i = 0; i < myArr4.Length; i++)
{
    Console.WriteLine(myArr4[i]);
}
Console.WriteLine();
#endregion


#region type05
// Does not indicate type of array 
var myArr5 = new[] { "orange", "pear", "kiwi" };
Console.WriteLine("type05 array");
for(int i = 0;i < myArr5.Length; i++)
{
    Console.WriteLine(myArr5[i]);
}
Console.WriteLine();
#endregion

#region system.index
// System.Index can be used as array index as well as int 
Index index = 1;
Console.WriteLine(myArr5[index]);

Index index2 = ^1; // count from end of array but it start at 1. ^1 means last element of array
Console.WriteLine(myArr5[index2]);
Console.WriteLine();
#endregion

#region multi dimension array
// 2 dimensional array initiated. 

string[,] myArr6 = new string[2, 2];
myArr6[0, 0] = "orange";
myArr6[0, 1] = "pear";
myArr6[1, 0] = "banana";
myArr6[1, 1] = "kiwi";

for (int i = 0; i < myArr6.GetLength(0); i++)// with GetLength, gets length of specific dimension length
{
    for(int j = 0; j < myArr6.GetLength(1); j++)
    {
        Console.WriteLine($"Multi Dimension Arry: {myArr6[i, j]}");
    }
}

#endregion


#region arraySegment
// arraySegment prevents cloning array. It points array.
int[] numbers = new int[3] { 2, 4, 6 };

ArraySegment<int> segment1 = new ArraySegment<int>(numbers);
// Points whole array
ArraySegment<int> segment2 = new ArraySegment<int>(numbers, 1, 2);
//Points array from 1 index and 2 element

Console.WriteLine("array segment");
foreach (var item in segment1)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in segment2)
{
    Console.WriteLine(item);
}
Console.WriteLine();

#endregion

#region arraysegment2
Console.WriteLine("array segment 2");
// Slicing array pointing object 
ArraySegment<int> segment3 = new ArraySegment<int>(numbers);
ArraySegment<int> segPart1 = segment3.Slice(0,1);
// Elements of numbers array from 0 index and 1 element
ArraySegment<int> segPart2 = segment3.Slice(1,2);
// Elements of numbers array from 1 index and 2 element

foreach (var item in segment3)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in segPart1)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in segPart2)
{
    Console.WriteLine(item);
}


Console.WriteLine();


#endregion



#region stringSegment
// For string operation arraySegment and stringSegment can be used. 
string text = "Hello world";
StringSegment sSegment = new StringSegment(text);
StringSegment sSegment2 = new StringSegment(text, 6, 5);
// Chars of text string from 6 index and 5 elements

Console.WriteLine("string segment");
Console.WriteLine(sSegment.ToString());
Console.WriteLine(sSegment2.ToString());

#endregion