// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(String [] args){

        Console.WriteLine("Çalışan sayısı {0}", Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Zeynep","Bastık","İK");
        Console.WriteLine("Çalışan sayısı {0}", Calisan.CalisanSayisi);

    }
}

class Calisan {
    private static int calisanSayisi;
    private string name;
    private string surname;
    private string departman;

    public Calisan(string name, string surname, string departman)
    {
        this.name = name;
        this.surname = surname;
        this.departman = departman;
        calisanSayisi+=1;
    }

    static Calisan(){
        calisanSayisi = 0;
    }

    public static int CalisanSayisi { get => calisanSayisi;  }
}
