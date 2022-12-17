using System; 

class URI {

    static void Main(string[] args) { 

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double average = ((A * 2) + (B * 3) + (C * 5)) / 10;
        Console.WriteLine($"MEDIA = {average:f1}");
    }

}