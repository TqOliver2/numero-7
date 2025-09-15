// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

bool val1 = true;
bool val2 = true;
bool val3 = true;


bool result = val1 && val2;
Console.WriteLine(result);

bool result2 = val1 || val2 || val3;
Console.WriteLine(result2);

bool result3 = (val1 && val2) || val3;
Console.WriteLine(result3);

bool result4 = !val1;
Console.WriteLine(result4);

bool resutl5 = val1 ^ val2 ^ val3; 
Console.WriteLine(resutl5);