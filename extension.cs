// See https://aka.ms/new-console-template for more information
class extension{
    static void Main(string [] args){

        string sentence ="Hello everyone, I am Sunay Terzi";
        Console.WriteLine(sentence.makeUpper());
        Console.WriteLine(sentence.makeLower());
         Console.WriteLine(sentence.removeSpace());

    }
}

public static class Extension {
    public static string makeUpper(this string param){
        return param.ToUpper();
    }
    public static string removeSpace(this string param){
        string [] arr = param.Split(" ");
        return string.Join("",arr);
    }

    public static string makeLower(this string param){
        return param.ToLower();
    }

}
