	using System;
	class ex3b
	{
		static int MaiorNumero(int a, int b)
		{
			if(a>b){
				int c = 0;
				return( c );
			}
			else if(b>a){
				int c = 1;
				return( c );
			}
			else
			{
				int c = -1;
				return( c );
			}
		}
		
		public static void Main()
		{
			int a;
			int b;
			int c;
			
			for(int i=0;i<5;i++){
				do
				{
					Console.WriteLine("\n Digite o valor de a: (deve ser positivo) ");
					a = int.Parse(Console.ReadLine());
				}while(a<0);
				
				do
				{
					Console.WriteLine("\n Digite o valor de b: (deve ser positivo) ");
					b = int.Parse(Console.ReadLine());
				}while(b<0);
				
				c = MaiorNumero(a,b);
				
				switch(c)
				{
					case 0 :
						Console.WriteLine("\n O Maior numero é " + a);
						break;
					case 1 :
						Console.WriteLine("\n O Maior numero é " + b);
						break;
					case -1:
						Console.WriteLine("\n Eles são iguais. ");
						break;
				}
				
			}
			
		}
	}