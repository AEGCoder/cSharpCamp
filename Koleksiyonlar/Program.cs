internal class Program
{
    private static void Main(string[] args)
    {
        
        string[] isimler = new string[]
        {
            "Ahmet",
            "Mehmet",
            "Ali",
            "Veli"
        };
        System.Console.WriteLine(isimler[0]);
        isimler[0] = "Ayşe";
        System.Console.WriteLine(isimler[0]);

    
        List<string> isimler2 = new List<string>()
        {
            "Eren",
            "Mehmet",
            "Ali",
            "Veli"
        };

        System.Console.WriteLine(isimler2[0]);
      isimler2.Add("Ayşe");
        System.Console.WriteLine(isimler2[4]);



    }
}