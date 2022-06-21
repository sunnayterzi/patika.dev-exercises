// See https://aka.ms/new-console-template for more information
class ListExample {

    static void Main(String [] args) {

        List<int> list1=new List<int>();
        list1.Add(1);
        list1.Add(25);
        list1.Add(54);
        list1.Add(74);
        list1.Add(87);
        list1.ForEach(num => Console.WriteLine(num));

        list1.Remove(1);
        list1.ForEach(num => Console.WriteLine(num));

        list1.RemoveAt(3);
        list1.ForEach(num => Console.WriteLine(num));

        Console.WriteLine(list1.BinarySearch(87));

        string [] animals = {"dog", "cat", "tiger", "bird"};
        List <String> strList = new List<string>(animals);
        strList.ForEach(str => Console.WriteLine(str));


    }
   

}



