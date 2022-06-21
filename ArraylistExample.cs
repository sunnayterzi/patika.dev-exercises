// See https://aka.ms/new-console-template for more information
using System.Collections;
ArrayList list1 = new ArrayList();
list1.Add(5);
list1.Add(false);
list1.Add("Sunay");
list1.Add("A");
foreach (var item in list1)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------------Add range--------------------");
String [] colour = {"white", "black", "yellow"};
list1.AddRange(colour);
foreach (var item in list1)
{
    Console.WriteLine(item);
}

Console.WriteLine("Before sorting operation");
ArrayList list2 = new ArrayList();
int [] intArr = {1,8,9,4,45,12,25,3};
list2.AddRange(intArr);
foreach (var item in list2)
{
    Console.WriteLine(item);
}
Console.WriteLine("After sorting operation");
list2.Sort();
foreach (var item in list2)
{
    Console.WriteLine(item);
}
Console.WriteLine("Binary search");
Console.WriteLine(list2.BinarySearch(12));




