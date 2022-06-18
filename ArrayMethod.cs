// See https://aka.ms/new-console-template for more information
int [] arr = {1,2,8,78,5,65,3,9};
foreach(int i in arr){
    Console.WriteLine(i);

}
Console.WriteLine("Sorted array");
Array.Sort(arr);
foreach(int i in arr){
    Console.WriteLine(i);
}
Console.WriteLine("Reverse Sorted array");
Array.Reverse(arr);
foreach(int i in arr){
    Console.WriteLine(i);
}

Console.WriteLine("clear array");
Array.Clear(arr, 0, 3);
foreach(int i in arr){
    Console.WriteLine(i);
}

Console.WriteLine("Get index of array");
Console.WriteLine(Array.IndexOf(arr, 5));
