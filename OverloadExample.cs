// See https://aka.ms/new-console-template for more information
class OverloadExample {
    static void Main(string [] args){
        ekranaYazdir(5);
        ekranaYazdir("hi!");

    }

    static void ekranaYazdir(int value){
        Console.WriteLine(value);
    }

    static void ekranaYazdir(string value){
        Console.WriteLine(value);
    }
    
}
