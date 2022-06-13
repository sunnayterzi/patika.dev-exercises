// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 8;
a+=2;
Console.WriteLine(a);

a/=2;
Console.WriteLine(a);

bool isCompleted = true;
bool isSuccess = true;

if(isCompleted && isSuccess) {
    Console.WriteLine("Operation succesfully completed");
}

a = 5;
int b = 2;

bool control = b < a;
Console.WriteLine(control);

a = 8;
b = 2;

int result = a*b;
Console.WriteLine(result);

result = a/b;
Console.WriteLine(result);

result = a % b;
Console.WriteLine(result);

double c = 5.0;
int f = 5;
double result3 = c+f;
Console.WriteLine(result3);

int tip_percent = 20;
int tax_percent = 8;

double meal = 12.0;
double tip1 = (double)(meal*(Convert.ToDouble(tip_percent)/100));
double tax2 = meal*(Convert.ToDouble(tax_percent)/100);
double total = meal + tip1 + tax2;
int total2 = (int)Math.Round(total);
Console.WriteLine(total2);

