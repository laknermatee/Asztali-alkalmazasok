namespace Asztali_09_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            double szam = double.Parse(Console.ReadLine());
            Console.WriteLine($"A szám kétszerese: { szam * 2}");
            
            Console.WriteLine("-----------------");

            // 4.feladat
            Console.WriteLine("Adj meg egy számot");
            double szam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            double szam2 = double.Parse(Console.ReadLine());
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
            /*
            


            // 7. feladat

            // 8. feladat

            


            /*
            // 9. feladat
            Console.WriteLine("Adj meg egy számot");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D >= 0) 
            {
                Console.WriteLine("Van megoldása");
            }
            else if (D < 0) 
            {
                Console.WriteLine("Nincs megoldása");
            }
            

            // 10. feladat
            Console.WriteLine("Adj meg egy számot");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                Console.WriteLine($"Az egynelet megoldása: {Math.Sqrt(D)}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Nincs megoldása");
            }
           
            // 11. feladat
            Console.WriteLine("Adj meg a háromszög befogóját");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg a háromszög másik befogóját");
            double b = double.Parse(Console.ReadLine());              
            double atfogo = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Az átfogó: {atfogo:F2}");

            

            // 12. feladat
            Console.WriteLine("Téglatest egyik éle:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Téglatest másik éle:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Téglatest harmadik éle:");
            double c = double.Parse(Console.ReadLine());

            double terfogat = a * b * c;
            double felszin = 2 * (a * b + a * c + b * c);

            Console.WriteLine($"A télatest térfogata: {terfogat:F2}");
            Console.WriteLine($"A télatest felszíne: {felszin:F2}");
            
          // 13. feladat

          Console.WriteLine("A kör átmérője:");
            double atmero = double.Parse(Console.ReadLine());
            double sugar = atmero / 2;

            double kerulet = atmero * Math.PI;
            double terulet = sugar * sugar * Math.PI;

            Console.WriteLine($"A kör kerülete: {kerulet:F2}");
            Console.WriteLine($"A télatest területe: {terulet:F2}");

              */

            // 14. feladat

            Console.WriteLine("Körív sugara:");
            double sugara = double.Parse(Console.ReadLine());
            Console.WriteLine("Középponti szöge:");
            double szoge = double.Parse(Console.ReadLine());

            double korivTerulet = szoge / 360  * (sugara * 2) * Math.PI;
            double hataroloIv = szoge / 360 * (sugara * sugara) * Math.PI;

            Console.WriteLine($"A körív területe: {korivTerulet:F2}");
            Console.WriteLine($"A határoló ív hossza: {hataroloIv:F2}");

            
        }
    }
}
