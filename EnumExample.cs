// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(String [] args){
        Console.WriteLine(Gunler.pazartesi);
        Console.WriteLine((int)Gunler.pazar);

    }
}

enum Gunler {
    pazartesi=1,
    salı,
    çarşamba,
    perşembe,
    cuma,
    cumartesi,
    pazar
}
