using System;

public class Person
{
	// Properti nama dan umur 
	public string Nama {get; set;} 
	public int Umur {get; set;} 
	
	// Metode Perkenalan
	public void Introduce () 
	{
		Console.WriteLine("Halo, nama saya adalah " +  Nama + " dan saya berumur " + Umur + " tahun." );
	}
}

// kelas Mahasiswa yang merupakan turunan dari kelas Person 
public class Mahasiswa : Person 
{
	// Properti ID siswa 
	public int MahasiswaId { get; set;}
	public int Semester {get; set;}
	public string Kampus {get; set;}
	
	// metode Studi
	public void study() 
	{
		Console.WriteLine(Nama+ " sedang belajar di semester " + Semester + " dan berkuliah di " + Kampus);
	}
}

// kelas program yang merupakan turunan dari kelas mahasiswa

class Program 
{
	static void Main(string[] args)
	{
		// membuat objek mahasiswa
		Mahasiswa s1 = new Mahasiswa ();
		
		// mengisi nilai 
		s1.Nama = "Rizko";
		s1.Umur = 24;
		s1.Semester = 8;
		s1.Kampus = "Universitas 17 Agustus 1945 Surabaya";
		s1.MahasiswaId = 1;
		
		//menajalan metode introduce
		s1.Introduce();
		
		//menjalankan metode study
		s1.study();
	}
}
