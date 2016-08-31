	using System;
	public class ClsAula04	
	{
	
		public static int total;
		
		public static void Main(String[]	args)	
		{	
			total =	10;
			A();
			total =	total+	B(20);
			C(30);
			Console.WriteLine("Total = " +	total);
		}
		
		public static void A	()
		{
		int i=0;
		for (i=0;	i<10;i++){
		total =	total +1;
		}
	}
	
	public static void C(int valor)
	{
		int total;
		if (valor>10){
		total =	50;
		}
		else{
		total =	valor;
		}
	}
	public static int B(int valor){
	if (valor>10){
	return 50;
	}
	else{
	return valor;
	}
	}
	}