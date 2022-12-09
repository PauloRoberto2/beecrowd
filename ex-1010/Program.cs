using System; 

class URI {

    static void Main(string[] args) { 

        string[] line1 = Console.ReadLine().Split(' ');   
        int num1 = int.Parse(line1[1]);
        decimal value1 = decimal.Parse(line1[2]);
        string[] line2 = Console.ReadLine().Split(' ');
        int num2 = int.Parse(line2[1]);
        decimal value2 = decimal.Parse(line2[2]);
        decimal total =  num1 * value1 + num2 * value2;
        Console.WriteLine($"VALOR A PAGAR: R$ {total}");

    }

}