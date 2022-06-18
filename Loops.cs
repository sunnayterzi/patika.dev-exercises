// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz");
int num = Convert.ToInt32(Console.ReadLine());


for (int i=2; i<=num; i++){
       
       if(num == 2) {
         Console.WriteLine("Bu bir asal sayıdır");
         break;
       }

    
       if (num % i ==0) { 
            Console.WriteLine("Bu asal sayı değil"); 
            break;
        }

       else {
        Console.WriteLine("Bu bir asal sayıdır");
        break;
       }
    


}


