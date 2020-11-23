using System;

class MainClass {
  public static void Main (string[] args) {
		double hamburguesa = 16;
    double papas = 3.5;
    double bebidas = 4.5;
		
		Console.WriteLine("======================");
		Console.WriteLine("Lista de precios:" + "\n" + 
		"HAMBURGUESA: " + hamburguesa + "\n" + "PAPAS: " + papas + "\n" + "BEBIDAS:" + bebidas);
		Console.WriteLine("======================");

 
    Console.WriteLine("Ingresa la cantidad de hamburgesas:");
    double pedido1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad de papas:");
    double pedido2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad de bebidas:");
    double pedido3 = double.Parse(Console.ReadLine());
    double total1 = hamburguesa * pedido1;
    double total2 = papas * pedido2;
    double total3 = bebidas * pedido3;
		
		Console.WriteLine("Total de la venta:");
    Console.WriteLine("HAMBURGUESAS: " + total1);
    Console.WriteLine("PAPAS: " + total2);
    Console.WriteLine("BEBIDAS: " + total3);
    double total = total1 + total2 + total3;
    Console.WriteLine("Valor a pagar:" + total);
    Console.WriteLine("Cuanto va a pagar:");
    double aPagar = double.Parse(Console.ReadLine());
    double vuelto = aPagar - total;
    Console.WriteLine("Vuelto es: " + vuelto);
  }
}
