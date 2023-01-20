using System;

class MainClass {
  public static void Main (string[] args) {
    int idadeDias, anos, meses, dias;

    //Lendo a idade em dias
    idadeDias = int.Parse(Console.ReadLine());

    //Calculando a idade em anos, meses e dias
    anos = idadeDias / 365;
    meses = (idadeDias % 365) / 30;
    dias = (idadeDias % 365) % 30;

    //Imprimindo a idade em anos, meses e dias
    Console.WriteLine(anos + " ano(s)");
    Console.WriteLine(meses + " mes(es)");
    Console.WriteLine(dias + " dia(s)");
  }
}
