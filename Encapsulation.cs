// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(String [] args){

        Ogrenci ogrenci1 = new Ogrenci("Elif", "Yalın", 29, 8);
        ogrenci1.sinifAtlat();
        ogrenci1.displayInfo();

    }
}

class Ogrenci {
    private string name;
    private string surname;
    private int no;
    private int sinif;

    public Ogrenci(String name, string surname, int no, int sinif){
        this.name = name;
        this.surname = surname;
        this.no = no;
        this.sinif = sinif;
    }
    

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int No { get => no; set => no = value; }
    public int Sinif { get => sinif; set => sinif = value; }

    public void displayInfo(){
        Console.WriteLine(name + " " + surname + " " + no + " " + " " + sinif);
    }

    public void sinifAtlat() {
        this.Sinif+=1;
    }
}
