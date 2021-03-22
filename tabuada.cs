using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Escolha um numero para a tabuada");
		var numero = int.Parse(Console.ReadLine());
		
		for(int i = 1; i <= 10; i++){
			Console.WriteLine("{0} x {1} = {2}", numero, i, (numero*i));
		};
		
	}
}