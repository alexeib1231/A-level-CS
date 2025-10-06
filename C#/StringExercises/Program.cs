// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
xdads
﻿List<string>  Wave(string str)
{
    List<string> waved = new List<string>();
    for (int i = 0; i < str.Length; i++)
    {
        str.ToLower();
        str[i].ToUpper();
        waved.Add(str);
    }
    return waved;
}
Console.WriteLine(Wave("hello"));