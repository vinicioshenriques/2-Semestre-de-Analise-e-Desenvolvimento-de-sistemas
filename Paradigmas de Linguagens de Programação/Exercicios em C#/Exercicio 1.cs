	using System;
	class ex1
	{
		static int func1(int B)
		{
			B=-100;
			Console.WriteLine("Valor de B dentro da função func1: " + B);
			return(B);
		}
		
		static int func2(int B)
		{
			B=-200;
			Console.WriteLine("Valor de B dentro da função func2: " + B);
			return(B);
		}

		public static void Main()
		{
			int	B;
			B	=	10;
			Console.WriteLine("Valor de B: " + B);
			B	=	20;
			func1( B );
			Console.WriteLine("Valor de B: " + B);
			B	=	30;
			func2( B );
			Console.WriteLine("Valor de B: " + B);
		}
	}