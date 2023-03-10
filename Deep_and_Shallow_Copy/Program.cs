#region DeepCopy

int deep1 = 10;
int deep2 = 20;

deep2 = deep1; // assigns value of variable
deep2 = 30;
Console.WriteLine($"deep1 : {deep1}");
Console.WriteLine($"deep2 : {deep2}");
#endregion
#region ShallowCopy

int shallow1 = 10;
ref int shallow2 = ref shallow1; // assigns memory address of variable
shallow2 = 20;

Console.WriteLine($"shallow1 : {shallow1}");
Console.WriteLine($"shallow2 : {shallow2}");

#endregion