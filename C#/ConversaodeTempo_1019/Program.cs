using System; 

class Program {

    static void Main(string[] args) { 

        int H_S = 3600;

        int time = int.Parse(Console.ReadLine());
        
        int hour = time / H_S;
        int min = (time - (H_S * hour)) / 60;
        int sec = time - (H_S * hour) - (min * 60);

        Console.WriteLine($"{hour}:{min}:{sec}");

        Console.ReadKey();

    }

}