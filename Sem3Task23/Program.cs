﻿int number = ReadData("Введите число: ");
string outLine = LineBuilder(number, 1);
PrintData("", outLine);
outLine = LineBuilder(number, 2);
PrintData("", outLine);


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, string res)
 {
    Console.WriteLine(msg + res);
 }

 string LineBuilder( int n, int pow)
 {
    string line = string.Empty;

    for (int i=1; i<n; i++)
    {
        line = line + Math.Pow (i, 3) + " ";
    }
    
    line = line + Math.Pow(n, 3);
    return line;
 }
