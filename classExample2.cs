// See https://aka.ms/new-console-template for more information
using System;

class classExample2 {
    static void Main(String [] args){

        Worker worker1 = new Worker("Ayşe","Uyar", "İK");
        worker1.displayInfo();

    }
}

class Worker {
    public string Name;
    public string Surname;
    public string Department;

    public Worker(string name, string surname, string department){
        this.Department=department;
        this.Name = name;
        this.Surname = surname;

    }

    public Worker(){

    }

    public void displayInfo(){
        Console.WriteLine(Name + " " + Surname + " " + Department);
    }
}







