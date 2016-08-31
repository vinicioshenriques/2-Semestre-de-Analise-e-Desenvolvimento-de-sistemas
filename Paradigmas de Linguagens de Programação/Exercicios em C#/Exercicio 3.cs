using System;
class test
{
	static float multiplica(float num1, float num2) //Função para Multiplicação
	{
		return(num1*num2);
	}
	static float soma(float num1, float num2)		//Função para Soma
	{
		return(num1+num2); 
	}
	static float divisao(float num1, float num2)	//Função para Divisão
	{
		return(num1/num2);
	}
	static float subtracao(float num1, float num2)	//Função para Subtração
	{
		return(num1-num2);
	}
	
	public static void Main()
	{
		
		int op=0;		//Variáveis inicializadas em 0 
		float num1=0;
		float num2=0;
		float resp=0;
		
		do{		// Loop para receber a opção da operação
				
			Console.WriteLine("\nEscolha uma opcao de calculo: ");  
			Console.WriteLine("\n1 - Multiplicacao \n2 - Soma\n3 - Divisao\n4 - Subtracao \n5 - Sair\n");
			
			do{	 // Loop para não aceitar opções que não estejam disponiveis

				op = int.Parse(Console.ReadLine());
				
				if ((op < 1) || (op>5)) // Se o numero não estiver entre as opções disponiveis receberá mensagem de opção invalida
					Console.WriteLine("\nOpcao invalida!!");
			}while ((op < 1) || (op>5));
		
			if (op != 5) // Se o numero for diferente de 5 que é a opção de saida, o programa segue e pede os numeros para fazer as operações
			{
				Console.WriteLine("\nDigite um numero: "); 
				num1 = float.Parse(Console.ReadLine());
				Console.WriteLine("\nDigite outro numero: "); 
				num2 = float.Parse(Console.ReadLine());
				
				switch (op) // Switch case para fazer a operação conforme a opção selecionada
				{
					case 1: // Caso tenha selecionado a Multiplicação
						resp= multiplica(num1, num2);
						break;
					case 2: // Soma
						resp= soma(num1, num2); 
						break;  
					case 3: //Divisão
						resp= divisao(num1, num2); 
						break;
					case 4: //Subtração
						resp= subtracao(num1, num2); 
						break;
				}
			}		
			if (op==5) // Se o numero selecionado for 5 o programa encerra
				Console.WriteLine("\nPrograma encerrado.....");
			else // Caso não tenho sido 5, e seja uma das opções validas, ele ira mostrar o resultado da operação
				Console.WriteLine("\nResultado da operação é " + resp);
		}while (op !=5);
	}	
}	
