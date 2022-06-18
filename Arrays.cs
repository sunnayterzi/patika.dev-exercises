// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please, enter size of the array");
int n = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[n];
Random random = new Random();

for(int i = 0; i<arr.Length; i++){
    arr[i] = random.Next();
}
for(int i = 0; i<arr.Length; i++){
    Console.Write(arr[i] + " ");
}




