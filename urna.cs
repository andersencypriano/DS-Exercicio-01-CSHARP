using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		int votoUrna;
		double totalVotos = 0;
		
		//Declaração de votos dos candidatos
		int cand1 = 0;
		int cand2 = 0;
		int cand3 = 0;
		int[] candVotos = new int[3]{cand1, cand2, cand3}; 
		
		do
		{
		//Input
		Console.WriteLine("Olá eleitor, suas opções de votos são: Cand1 = 1, Cand2 = 2, Cand3 = 3");
		votoUrna = int.Parse(Console.ReadLine());

		totalVotos++;
		Console.Clear();

		//Computa os votos
		switch (votoUrna)
		{
		  case 1:
			 cand1++;
				candVotos[0] = cand1;
			  break;
		  case 2:
			  cand2++;
				candVotos[1] = cand2;
			  break;
		  case 3:
			  cand3++;
				candVotos[2] = cand3;
			  break;
		  default:
				if(votoUrna == 0 ){
					totalVotos--;
				}else {
					Console.WriteLine("Voto inválido, tente novamente!");
					totalVotos--;
				}
				break;
		}
			
		}while(votoUrna !=0);
		Console.WriteLine("Eleição encerrada, total de votos:{0}", totalVotos);
		
		Console.WriteLine("O Candidato1, recebeu:{0}", cand1);
		Console.WriteLine("O Candidato2, recebeu:{0}", cand2);
		Console.WriteLine("O Candidato3, recebeu:{0}", cand3);

		int maxVotos = candVotos.Max();
 		int indiceVencedor = candVotos.ToList().IndexOf(maxVotos);
		
		switch (indiceVencedor + 1)
		{
		  case 1:
				Console.WriteLine("O Candidato1 foi eleito com {0} votos - Total de: {1:n0} dos votos", cand1, cand1 / totalVotos * 100);
			  break;
		  case 2:
			  Console.WriteLine("O Candidato2 foi eleito com {0} votos - Total de: {1:n0} dos votos", cand2, cand2 / totalVotos * 100);
			  break;
		  case 3:
			   Console.WriteLine("O Candidato3 foi eleito com {0} votos - Total de: {1:n0}% dos votos", cand3, cand3 / totalVotos * 100);
			  break;
		  default:
				break;
		}
	}
};