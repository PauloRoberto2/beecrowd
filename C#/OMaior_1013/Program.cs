using System; 

class URI {

    static void Main(string[] args) { 

        //Coleta de dados
        string[] line1 = Console.ReadLine().Split(' ');
        int A = int.Parse(line1[0]); 
        int B = int.Parse(line1[1]);
        int C = int.Parse(line1[2]);
        //Calculos
        int maiorAB = (A + B + Math.Abs(A - B)) / 2;
        int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) /2;
        //Prints      
        Console.WriteLine($"{maiorABC} eh o maior");
    }

}