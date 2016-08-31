	using System;
	class ex3c
	{
		static int num=0;
		static int soma=0;
		
		public static int LePositivo()
		{	
			do{
				Console.WriteLine("\n Digite um numero positivo: ");
				num = int.Parse(Console.ReadLine());
			}while(num<0);
			return(num);
		}
		
		public static int Somatorio(int num)
		{
			for(int i=1;i<=num;i++)
			{
				soma = soma + i;
			}
			return(soma);
		}
		
		public static void Main()
		{
			for(int i=0;i<5;i++)
			{
				LePositivo();
				soma = Somatorio(num);
				Console.WriteLine(" O somatorio dos numeros de 1 ao numero digitado e " + soma);
			}
			
			
		}
	}