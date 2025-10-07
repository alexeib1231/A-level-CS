using System.Diagnostics;
List<string>  Wave(string str)
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
Debug.Assert(Wave("hello").SequenceEqual(new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" }));