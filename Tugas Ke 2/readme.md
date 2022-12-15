using System;

// Kelas abstrak (abstract class) yang mengimplementasikan konsep abstraksi
abstract class Siswa
{
    // Property untuk menyimpan nama siswa dan umur siswa
    public string Name { get; set; }
	public float Umur { get; set; }
    // Method abstrak (abstract method) yang harus diimplementasikan oleh kelas turunannya
    public abstract void PrintGrade();
}

// Kelas siswa Mahasiswa yang merupakan turunan dari kelas Siswa
class MahasiswaBachelor : Siswa
{
    // Property untuk menyimpan nilai rata-rata Mahasiswa
    public double AverageGrade { get; set; }

    // Implementasi dari method PrintGrade() yang diwariskan dari kelas Siswa
    public override void PrintGrade()
    {
        Console.WriteLine($"Mahasiswa yang bernama {Name}, yang berumur {Umur} tahun memiliki IPK rata-rata {AverageGrade}");
    }
}

// Kelas siswa SMA yang merupakan turunan dari kelas Siswa
class SekolahMenengahAtas : Siswa
{
    // Property untuk menyimpan nilai rata-rata siswa SMA
    public double AverageGrade { get; set; }

    // Implementasi dari method PrintGrade() yang diwariskan dari kelas Siswa
    public override void PrintGrade()
    {
        Console.WriteLine($"Siswa SMA yang bernama {Name}, yang berumur {Umur} tahun memiliki nilai rata-rata {AverageGrade}");
    }
}

// Kelas siswa SD yang merupakan turunan dari kelas Siswa
class SekolahDasar : Siswa
{
    // Property untuk menyimpan nilai siswa SD
    public char Grade { get; set; }

    // Implementasi dari method PrintGrade() yang diwariskan dari kelas Siswa
    public override void PrintGrade()
    {
        Console.WriteLine($"Siswa SD yang bernama {Name}, yang berumur {Umur} tahun memiliki nilai {Grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
		// Membuat objek Mahasiswa dan mengisi nilai untuk property Name, Umur dan AverageGrade
       	MahasiswaBachelor S1 = new 	MahasiswaBachelor();
        S1.Name = "Rizko";
		S1.Umur = 24;
        S1.AverageGrade = 4;
		
        // Membuat objek siswa SMA dan mengisi nilai untuk property Name, Umur dan AverageGrade
        SekolahMenengahAtas SMA = new SekolahMenengahAtas();
        SMA.Name = "Febri";
		SMA.Umur = 17;
        SMA.AverageGrade = 3.5;

        // Membuat objek siswa SD dan mengisi nilai untuk property Name, Umur dan Grade
        SekolahDasar SD = new SekolahDasar();
        SD.Name = "Rachmayadi";
		SD.Umur = 5;
        SD.Grade = 'A';

		// Memanggil method PrintGrade() pada objek siswa Bachelor
        S1.PrintGrade();
		
        // Memanggil method PrintGrade() pada objek siswa SMA
        SMA.PrintGrade();

        // Memanggil method PrintGrade() pada objek siswa SD
        SD.PrintGrade();
    }
}
