using System; 

class URI {

    static void Main(string[] args) { 

        int num = int.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());
        double value = double.Parse(Console.ReadLine());
        double wage = hour * value;
        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine($"SALARY = U$ {wage:F2}");
    }

}