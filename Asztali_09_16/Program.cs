namespace Asztali_09_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.feladta
            Console.WriteLine("Hello, World!");
           
            Console.WriteLine("-----------");

            // 2.feladat
            Console.WriteLine("Add meg a neved");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
            
            Console.WriteLine("-----------------");

            // 3.feladat
            Console.WriteLine("Adj meg egy számot");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A szám kétszerese: { szam * 2}");
            
            Console.WriteLine("-----------------");

            // 4.feladat
            Console.WriteLine("Adj meg egy számot");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            int szam2 = int.Parse(Console.ReadLine());
             Console.WriteLine("------------");
            Console.WriteLine($"A számok összege: {szam1 + szam2}");
            Console.WriteLine($"A számok különbsége: {szam1 % szam2}");
            Console.WriteLine($"A számok szorzata: {szam1 * szam2}");
           
            if (szam1 > szam2)
            {
                Console.WriteLine(szam1 - szam2);
            }
            else
            {
                Console.WriteLine(szam2 - szam1);
            }
            Console.WriteLine("------------");

            // 5.feladat

            Console.WriteLine("Adj meg egy számot");
            int szam3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            int szam4 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");

            if (szam3 > szam4) {
                Console.WriteLine($"A nagyobbik szám: {szam3}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szam4}");
            }
            Console.WriteLine("------------");

            // 6.feladat

            Console.WriteLine("Adj meg egy számot");
            int szam5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            int szam6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            int szam7 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");

            if (szam5 < szam6 && szam5 < szam7)
            {
                Console.WriteLine($"A legkisebb szám: {szam5}");
            }
            else if (szam6 < szam5 && szam6 < szam7) {
                
                Console.WriteLine($"A legkisebb szám: {szam6}");
            }
            else
            {
                Console.WriteLine($"A legkisebb szám: {szam7}");
            }
            Console.WriteLine("------------");
            // 7. feladat

            // 8. feladat

            // 9. feladat

            // 10. feladat

            // 11. feladat

            // 12. feladat

            // 13. feladat

            // 14. feladat
            Console.WriteLine();

        }
    }
}
