using System;
using System.Linq;

public class Triangulo {
	private double _lado1;
	private double _lado2;
	private double _lado3;
	private double [] lados;
	
	//Construtor
	public Triangulo(double lado1, double lado2, double lado3){
		_lado1 = lado1;
		_lado2 = lado2;
		_lado3 = lado3;
		lados = new double[3]{ lado1, lado2, lado3}; 
	}
	
	//Retorna o numero de ocorrencias de repetição =]
	public int ladosRepetidos () {
		return  lados.Length - lados.Distinct().Count();
	}	
};

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Vamos descobrir o tipo do triângulo, insira o 1º valor do lado do triângulo");
		var lado1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Insira o 2º valor do lado do triângulo");
		var lado2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Insira o 3º valor do lado do triângulo");
		var lado3 = int.Parse(Console.ReadLine());
		
		//Instancia a classe para iniciala.
		var triangulo = new Triangulo(lado1, lado2, lado3);
		
		var resultado = triangulo.ladosRepetidos();
		
		switch (resultado) {
			case 0:
				Console.WriteLine("Todos os lados diferentes, portanto ele é:  Escaleno");
				break;
			case 1:
				Console.WriteLine("2 lados iguais, portanto ele é:  Isósceles");
				break;
			case 2:
				Console.WriteLine("Todos os lados são iguais, porantanto ele é:  Equilátero");
				break;
		};
		
	}
}