using System;
	class imc
	{
		static float Imc(float peso, float altura) // Função que calcula o IMC
		{
			return(peso/(altura*altura));
		}
		
		public static void Main()
		{
			string nome=" "; 	// String para o Nome
			string sexo=" ";	// String para o Sexo
			float peso=0;		// Float para o peso	
			float altura=0;		// Float para a altura
			float imc=0;		// e float para o imc
			
			Console.WriteLine("\n Digite seu nome: ");
			nome = Console.ReadLine();
			
			Console.WriteLine("\n Digite seu Peso: ");
			peso = float.Parse(Console.ReadLine());
			
			Console.WriteLine("\n Digite sua Altura: ");
			altura = float.Parse(Console.ReadLine());
			
			Console.WriteLine("\n Digite seu Sexo [ Masculino // Feminino ]: ");
			sexo = Console.ReadLine();
			
			imc = Imc(peso,altura);
			
			if(imc<18.5)
				Console.WriteLine("\n " + nome + ", do sexo " + sexo + ", tem o IMC de " + imc + ", abaixo do peso ideal.");
			if(imc>=18.5 && imc<=25)
				Console.WriteLine("\n " + nome + ", do sexo " + sexo + ", tem o IMC de " + imc + ", no peso ideal.");
			if(imc>25 && imc<=30)
				Console.WriteLine("\n " + nome + ", do sexo " + sexo + ", tem o IMC de " + imc + ", acima do peso ideal.");
			if(imc>30)
				Console.WriteLine("\n " + nome + ", do sexo " + sexo + ", tem o IMC de " + imc + ", obeso.");
		}
	}