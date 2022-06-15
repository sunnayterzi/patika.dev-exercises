// See https://aka.ms/new-console-template for more information

// implicit conversion
byte a = 5;
short b =8;
int c = a+b;
Console.WriteLine("c: "+ c);

long f = c;
Console.WriteLine("f: " + f);

string g = "Hello";
char h = 'b';
object y = g+h+b;
Console.WriteLine("y: " + y);

// Explicit conversion
int v = 8;
byte l = (byte)v;
Console.WriteLine("l:" + l);

int ab = 6;
string yy = ab.ToString();
Console.WriteLine("yy: "+yy);

string s1 = "25", s2 = "50";
int num1, num2;
int sum;
num1 = Convert.ToInt32(s1);
num2 = Convert.ToInt32(s2);
sum = num1+num2;
Console.WriteLine("sum: " + sum);

string s3 = "89";
int num3;
num3 = int.Parse(s3);
Console.WriteLine("num3: " + num3);


