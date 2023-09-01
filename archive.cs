using System;
					
	public class Program{
	public static void Main(){

	Random coin = new Random();
	int flip = coin.Next(0,2);
			
	if(flip == 0){
			
	Console.WriteLine("Cara", "Head");	}
		
		else{		
	Console.WriteLine("Coroa", "Tails");
		
		}	
	}
}
