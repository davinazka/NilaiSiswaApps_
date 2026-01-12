int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Input nama siswa");
nama = Console.ReadLine();
Console.Write("Input nilai siswa");
nilai = int.Parse (Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Siswa lulus");
}
else
{
    Console.WriteLine("Siswa tidak lulus yey");
}
