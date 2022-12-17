using System;

class URI {

    static void Main(string[] args) {

        
        int time = int.Parse(Console.ReadLine());
        int average = int.Parse(Console.ReadLine());

        double litro = (time * average) / 12.00;

        Console.WriteLine($"{litro:f3}");
    }
}