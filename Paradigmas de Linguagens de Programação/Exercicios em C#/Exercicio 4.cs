
	using System;

	public class ClsPrincipal	
	{
		public static int anoNascimento;
		public static int idade=0;
	
		public static int CalculaIdade(int anoNascimento)
		{
			idade =	2016-anoNascimento;
			return(idade);
		}
	
		public static void VerificaMaiorMenor(int idade)	
		{
			if (idade>=18)
			{
			Console.WriteLine("Maior de idade");
			}
			else
			{
			Console.WriteLine("Menor de idade");
			}
		}
		
		public static void Main()	
		{
			int idade;
			Console.WriteLine("Entre com o ano de nascimento: ");
			anoNascimento =	int.Parse(Console.ReadLine());
			idade =	CalculaIdade(anoNascimento);
			VerificaMaiorMenor(idade);
		}
	}