using System; 

class URI {

    static void Main(string[] args) { 

        //Coleta de dados
        string[] line1 = Console.ReadLine().Split(' ');
        double A = double.Parse(line1[0]);
        double B = double.Parse(line1[1]);
        double C = double.Parse(line1[2]);
        //Calculos
        double pi = 3.14159;
        double tri = (A * C) / 2;
        double cir = pi * (Math.Pow(C, 2));
        double tra = (A + B) * C / 2;
        double qua = Math.Pow(B, 2);
        double ret = A * B;
        //Prints
        Console.WriteLine($"TRIANGULO: {tri:f3}");        
        Console.WriteLine($"CIRCULO: {cir:f3}");
        Console.WriteLine($"TRAPEZIO: {tra:f3}");
        Console.WriteLine($"QUADRADO: {qua:f3}");
        Console.WriteLine($"RETANGULO: {ret:f3}");

    }

}