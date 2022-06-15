// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("Please, enter a number");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The entered number is " + a);
}
catch (System.Exception e)
{
    
    Console.WriteLine(e);
}

finally {
    Console.WriteLine("Operation was completed");
}
