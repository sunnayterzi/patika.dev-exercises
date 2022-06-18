// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Notunuz nedir? Birini giriniz (0-50-100)");
int not = Convert.ToInt32(Console.ReadLine());

switch(not) {
    case 50 :
        Console.WriteLine("Koşullu");
        break;
    case 0:
        Console.WriteLine("Başarısız");
        break;
    case 100:
        Console.WriteLine("Başarılı");
        break;

}
