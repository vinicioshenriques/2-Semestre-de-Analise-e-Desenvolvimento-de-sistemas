	using System;
	class ex3a
	{
		static int absoluto(int n)
		{
			if(n<0){
				n=n*-1;
			}
			return(n);
		}
		
		public static void Main()
		{
			int n;
			
			for(int i=0;i<10;i++){
				Console.WriteLine("\n Digite o valor que deseja saber o correnpondente absoluto: ");
				n = int.Parse(Console.ReadLine());
				n = absoluto( n );
				Console.WriteLine("\n O valor absoluto do numero digitado é " + n);
			}
			
		}
	}