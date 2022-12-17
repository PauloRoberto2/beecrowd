using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double consumption = X / Y;

        Console.WriteLine($"{consumption:f3} km/l");
    }

}