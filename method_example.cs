// See https://aka.ms/new-console-template for more information
class method_example{
    static void Main (string [] args){

        topla(8,5);
        cikar(8,5);
        carp(8,5);
        
    }

    static void topla(int a, int b){
        Console.WriteLine("Toplam: " + (a+b));
    }

    static void cikar(int a, int b){
        Console.WriteLine("Çıkarma: " + (a-b));
    }

    static void carp(int a, int b){
        Console.WriteLine("Çarpım: " + (a*b));
    }


}


