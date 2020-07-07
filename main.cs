using System;

public class Program
{
	static int F(int fatorando){
		int fatorial=0, soma_alg=0;
		
		if(fatorando>1){
			fatorial=fatorando * F(fatorando-1);
			soma_alg=fatorial%10+fatorial%100/10+fatorial%1000/100+fatorial/1000;
			Console.WriteLine(Convert.ToString(soma_alg));
			return(fatorial);
		}
		else{
			Console.WriteLine(1);
			return 1;
		}
	}

	public static void Main()
	{
		int a=0;
		a=Program.F(7);
	}
}
