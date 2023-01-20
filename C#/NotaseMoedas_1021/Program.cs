using System;

class MainClass {
  public static void Main (string[] args) {
    double valor = double.Parse(Console.ReadLine()); // lê o valor de entrada
    int valorInt = (int)(valor * 100); // converte para inteiro, multiplicando por 100 para ignorar casas decimais
    int[] notas = { 10000, 5000, 2000, 1000, 500, 200 }; // notas disponíveis
    int[] moedas = { 100, 50, 25, 10, 5, 1 }; // moedas disponíveis
    Console.WriteLine("NOTAS:");
    for (int i = 0; i < notas.Length; i++) { // percorre as notas
      int quantidade = valorInt / notas[i]; // calcula a quantidade de notas
      valorInt = valorInt % notas[i]; // atualiza o valor restante
      Console.WriteLine(quantidade + " nota(s) de R$ " + notas[i] / 100.0); // imprime a quantidade de notas
    }
    Console.WriteLine("MOEDAS:");
    for (int i = 0; i < moedas.Length; i++) { // percorre as moedas
      int quantidade = valorInt / moedas[i]; // calcula a quantidade de moedas
      valorInt = valorInt % moedas[i]; // atualiza o valor restante
      Console.WriteLine(quantidade + " moeda(s) de R$ " + moedas[i] / 100.0); // imprime a quantidade de moedas
    }
  }
}
