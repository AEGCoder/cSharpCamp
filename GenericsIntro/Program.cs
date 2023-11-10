internal class Program
{
    private static void Main(string[] args)
    {
        myList<string> isimler = new myList<string>();
        isimler.Add("Engin");

        System.Console.WriteLine(isimler.Length);
        isimler.Add("Kerem");

        System.Console.WriteLine(isimler.Length);

        foreach (var item in isimler.Items)
        {
            System.Console.WriteLine(item);
        }

             

    }
}