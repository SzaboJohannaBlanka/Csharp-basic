namespace Gyakorlat20240912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine();

            int Szam1 = 5;
            int Szam2 = 2;
            int Szam3 = Szam1/Szam2;
            // ekkor két egész számot osztottunk el oly módon, hogy egész szám legyen a kimenete
            Console.WriteLine($"{Szam3} / {Szam2} = {Szam3}");
            int Szam4 = Szam1 % Szam2;
            // két százalékos szám maradékos osztás hajtotta végre, ekkor a maradék érdekelt minket ami egész szám
            Console.WriteLine($"Maradékos osztás: {Szam1} % {Szam2} = {Szam4}");
            // hogyan lesz az osztás tizedes tört?
            double Tizedestort = (double)Szam1 / (double)Szam2; // azzal hogy zárójelben odaírva, hogy double átkényszerítem a számot egy másik számrendszerben
            Console.WriteLine($"Maradékos osztás: {Szam1} / {Szam2} = {Szam3}");

            //bekérés
            Console.Write( "Kérem adja meg a nevét: " );
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg az életkorát: ");
            int Eletkor = int.Parse( Console.ReadLine() );
            int Kulonbseg = 18 - Eletkor;
            if (Kulonbseg < 0)
            {
                Console.WriteLine($"Ön már nagykorú");
            }
            if (Kulonbseg == 0)
            {
                Console.WriteLine($"Gratutálok, pont nagykorú vagy");
            }
            if (Kulonbseg > 0) 
            {
                Console.WriteLine($"Sajnos te még kiskorú vagy, várj {Kulonbseg} évet");
           
            }
            */
            Random rnd = new Random();
            Console.WriteLine("Szia írd be a neved kérlek: ");
            string Nev1=Console.ReadLine();
            Console.Write("Kérlek válassz egy egész számot 1-10 között: ");
            int JatekosSzama = int.Parse(Console.ReadLine());
            int GepiSzama = rnd.Next(1, 11);
            if (GepiSzama < JatekosSzama)
            {
                Console.WriteLine($"Gratulálok {Nev1}, te nyertél!");
            }
            if (GepiSzama == JatekosSzama)
            {
                Console.WriteLine($"Ez döntetlen");
            }
            if (GepiSzama > JatekosSzama)
            {
                Console.WriteLine($"Sajnálom {Nev1}, most vesztettél! A gép száma: {GepiSzama}");
            }






        }
    }
}
