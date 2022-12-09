using System; 

class URI {

    static void Main(string[] args) { 

        string name = Console.ReadLine();
        double wage = double.Parse(Console.ReadLine());
        double sales = double.Parse(Console.ReadLine());
        double total = wage + sales * 0.15 ;
        Console.WriteLine($"TOTAL = R$ {total:f2}");

        Console.ReadLine();
    }

}