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

              

            // 14. feladat

            Console.WriteLine("Körív sugara:");
            double sugara = double.Parse(Console.ReadLine());
            Console.WriteLine("Középponti szöge:");
            double szoge = double.Parse(Console.ReadLine());

            double korivTerulet = szoge / 360  * (sugara * 2) * Math.PI;
            double hataroloIv = szoge / 360 * (sugara * sugara) * Math.PI;

            Console.WriteLine($"A körív területe: {korivTerulet:F2}");
            Console.WriteLine($"A határoló ív hossza: {hataroloIv:F2}");

            */


            // 15. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int sz15 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sz15; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // 16. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int sz16 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sz16; i++)
            {
                Console.WriteLine(i);
            }


            // 17. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int sz17 = int.Parse(Console.ReadLine());
            Console.WriteLine("A(z) " + sz17 + " osztói:");
            for (int i = 1; i <= sz17; i++)
            {
                if (sz17 % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();


            // 18. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int sz18 = int.Parse(Console.ReadLine());
            int ossz18 = 0;
            for (int i = 1; i <= sz18; i++)
            {
                if (sz18 % i == 0)
                    ossz18 += i;
            }
            Console.WriteLine($"Az osztók összege: {ossz18}");


            // 19. feladat
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int sz19 = int.Parse(Console.ReadLine());
            int ossz19 = 0;
            for (int i = 1; i < sz19; i++)
            {
                if (sz19 % i == 0)
                    ossz19 += i;
            }
            if (ossz19 == sz19)
                Console.WriteLine("A szám tökéletes szám.");
            else
                Console.WriteLine("A szám nem tökéletes szám.");


            // 20. feladat
            Console.WriteLine("Hatványalap:");
            int alap20 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kitevő:");
            int kitevo20 = int.Parse(Console.ReadLine());
            int hatvany20 = 1;
            for (int i = 1; i <= kitevo20; i++)
            {
                hatvany20 *= alap20;
            }
            Console.WriteLine($"Hatványérték: {hatvany20}");


            // 21. feladat
            int sz21;
            do
            {
                Console.WriteLine("Adj meg egy pozitív számot:");
                sz21 = int.Parse(Console.ReadLine());
            } while (sz21 <= 0);
            Console.WriteLine($"Elfogadott szám: {sz21}");


            // 22. feladat
            int ossz22 = 0;
            int sz22;
            do
            {
                Console.WriteLine("Adj meg egy számot:");
                sz22 = int.Parse(Console.ReadLine());
                if (sz22 < 100)
                    ossz22 += sz22;
            } while (sz22 < 100);
            Console.WriteLine($"A 100 alatti számok összege: {ossz22}");


            // 23. feladat
            Console.WriteLine("Adj meg egy egész számot:");
            int sz23 = int.Parse(Console.ReadLine());
            Console.Write($"{sz23} = ");
            bool elso23 = true;
            while (sz23 % 2 == 0)
            {
                if (!elso23) Console.Write("*");
                Console.Write("2");
                sz23 /= 2;
                elso23 = false;
            }
            if (sz23 > 1)
            {
                if (!elso23) Console.Write("*");
                Console.Write(sz23);
            }
            Console.WriteLine();


            // 24. feladat
            string szo24;
            do
            {
                Console.WriteLine("Írd be a szót:");
                szo24 = Console.ReadLine();
            } while (szo24 != "alma");
            Console.WriteLine("Az alma gyümölcs!");


            // 25. feladat
            Console.WriteLine("Adj meg egy egész számot:");
            int sz25 = int.Parse(Console.ReadLine());
            Console.Write($"{sz25} = ");
            while (sz25 >= 3)
            {
                Console.Write("3+");
                sz25 -= 3;
            }
            Console.WriteLine(sz25);
        }
    }
}
