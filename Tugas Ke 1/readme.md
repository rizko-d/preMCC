using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			// inisialisasi variabel
			int number1 = 4;
			int number2 = 2;
			
			// menggunakan operator aritmatika
			int result = number1 * number2;
			Console.WriteLine("Hasil perkalian: " +result);
			
			// menggunakan perbandingan operator
			if (number1 > number2) 
			{
				Console.WriteLine(number1 + "Lebih Besar dari" + number2);
			}
			else
			{
				Console.WriteLine(number1 + "Lebih Kecil dari" + number2);
			}
			
			// menggunakan perulangan 
			Console.WriteLine("Contoh Perulangan menggunakan For : ");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(i);
			}
			
			// menggunakan method
			int resultFromMethod = Calculate(number1, number2);
			Console.WriteLine("Hasil pertambahan menggunakan method : "+resultFromMethod);
		}
		// method untuk melakukan pertambahan
		static int Calculate(int num1, int num2)
		{
			return num1 + num2;
		}
	}
}
