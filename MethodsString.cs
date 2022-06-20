// See https://aka.ms/new-console-template for more information
string str1 = "Hello, I am going to present my project";
string str2 = "This project is about string methods";

Console.WriteLine(str1.Length);

Console.WriteLine(String.Concat(str1,str2));
Console.WriteLine(String.Compare(str1,str2,true));
Console.WriteLine(str2.Contains("about"));
Console.WriteLine(str2.EndsWith("project"));
Console.WriteLine(str1.Insert(0,"*"));
Console.WriteLine(str1.Remove(0,5));
Console.WriteLine(str1.Replace("hello","hi"));
Console.WriteLine(str1.Substring(0,5));

