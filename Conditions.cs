// See https://aka.ms/new-console-template for more information


Console.WriteLine("Notunuzu giriniz");
int a = Convert.ToInt32(Console.ReadLine());

if(a<45) {
    Console.WriteLine("Kaldiniz");
}
else if(45<=a && a<60) {
    Console.WriteLine("Kosullu gectiniz");
}

else {
    Console.WriteLine("Gectiniz");
}

string sonuc = a<45 ? "Kaldiniz" : a<60 && a>=45 ? "Kosullu gectiniz" : "Kaldiniz";
