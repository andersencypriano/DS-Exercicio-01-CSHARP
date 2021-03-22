using System;
public class Funcionario
{
	//Atributos
	private string _nomeFuncionario;
	private double _salarioFuncionario;
	
	//Impostos
	private double _impostoIrs = 0.12;
	private double _impostoSegurancaSocial = 0.15;
	
	//Construtor
	public Funcionario(string nome, double salario){
		_nomeFuncionario = nome;
		_salarioFuncionario = salario;
	}
	
	//Método para mostrar as Informações sobre o funcionario criado.
	public string Infos (){
		return "Nome: " + _nomeFuncionario + " | " + "Salário bruto: R$" + _salarioFuncionario;
	}
	
	//Método que retorna o salario liquido com retenção de IRS
	public double salarioTaxaIrs (){
		return _salarioFuncionario * _impostoIrs;
	}
	
	//Método que retorna o salario liquido com retenção de Segurança Social
	public double salarioTaxaSegurancaSocial (){
		return _salarioFuncionario * _impostoSegurancaSocial;
	}
	
	//Método que calcula o desconto no salário bruto
	public double salarioLiquido (){
		return _salarioFuncionario - (_salarioFuncionario * _impostoIrs) - (_salarioFuncionario * _impostoSegurancaSocial);
	}

}
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Olá, digite o nome do funcionário:");
		string nome = Console.ReadLine();
		
		Console.WriteLine("Insira o valor do salário a ser calculado:");
		var salarioBruto = int.Parse(Console.ReadLine());
		
		var funcionario = new Funcionario(nome, salarioBruto);
		Console.WriteLine(funcionario.Infos());
		Console.WriteLine("-------------------");
		
		Console.WriteLine("Valor da rentenção do IRS (12%): R$ "+ funcionario.salarioTaxaIrs());
		Console.WriteLine("Valor da rentenção de Segurança Social (15%): R$ "+ funcionario.salarioTaxaSegurancaSocial());
		Console.WriteLine("Salário Liquido com IRS e Segurança Social: R$ "+ funcionario.salarioLiquido());
	}
}