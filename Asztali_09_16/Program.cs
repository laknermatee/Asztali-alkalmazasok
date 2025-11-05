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
<<<<<<< HEAD
            static int EgeszSzamBeker(string uzenet)
            {
                int szam;
                while (true)
                {
                    Console.Write(uzenet);
                    try
                    {
                        szam = int.Parse(Console.ReadLine());
                        return szam;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Hiba! Kérlek adj meg egy érvényes egész számot!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Hiba! A szám túl nagy vagy túl kicsi!");
                    }
                }
            }

=======
>>>>>>> e0bb23c87cdd55ac8a5a57a7de9ce38c62c98215


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
<<<<<<< HEAD

            static void f34()
            {
                Console.WriteLine("Kétjegyű számpárok, ahol a szorzat nem változik a számjegyek felcserélésével:");

                for (int x = 10; x <= 99; x++)
                {
                    for (int y = x + 1; y <= 99; y++)
                    {
                        int x1 = x / 10;
                        int x2 = x % 10;
                        int y1 = y / 10;
                        int y2 = y % 10;

                        int x_ford = x2 * 10 + x1;
                        int y_ford = y2 * 10 + y1;

                        if (x * y == x_ford * y_ford)
                        {
                            Console.WriteLine($"{x} és {y} (mert {x}*{y} = {x * y} és {x_ford}*{y_ford} = {x_ford * y_ford})");
                        }
                    }
                }
            }

            static void f35()
            {
                int maxSor = 10;
                int osszesBetu = 26;
                int oszlopok = (osszesBetu + maxSor - 1) / maxSor;

                for (int sor = 0; sor < maxSor; sor++)
                {
                    for (int oszlop = 0; oszlop < oszlopok; oszlop++)
                    {
                        int index = sor + oszlop * maxSor;
                        if (index < osszesBetu)
                        {
                            char betu = (char)('a' + index);
                            Console.Write($"{betu}  {((int)betu),-3}  ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            static void f36()
            {
                int sorok = EgeszSzamBeker("Add meg a sorok számát: ");
                int oszlopok = EgeszSzamBeker("Add meg az oszlopok számát: ");

                for (int i = 0; i < sorok; i++)
                {
                    for (int j = 0; j < oszlopok; j++)
                    {
                        if ((i + j) % 2 == 0)
                            Console.Write("X");
                        else
                            Console.Write("O");
                    }
                    Console.WriteLine();
                }
            }

            static void f37()
            {
                int a = EgeszSzamBeker("Add meg a háromszög magasságát: ");

                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void f38()
            {
                int a = EgeszSzamBeker("Add meg a háromszög magasságát: ");

                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= a - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void f39()
            {
                int M = EgeszSzamBeker("Add meg a téglalap magasságát (M): ");
                int N = EgeszSzamBeker("Add meg a téglalap szélességét (N): ");

                for (int i = 1; i <= M; i++)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        if (i == 1 || i == M || j == 1 || j == N)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            static void f40()
            {
                int limit = EgeszSzamBeker("Add meg a felső határt: ");

                Console.WriteLine($"Tökéletes számok 1-től {limit}-ig:");

                for (int szam = 1; szam <= limit; szam++)
                {
                    int osszeg = 0;
                    for (int i = 1; i <= szam / 2; i++)
                    {
                        if (szam % i == 0)
                        {
                            osszeg += i;
                        }
                    }

                    if (osszeg == szam && szam > 0)
                    {
                        Console.Write(szam + " ");
                    }
                }
                Console.WriteLine();
            }

            static void f41()
            {
                Console.WriteLine("Vigenère-tábla:");

                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        char betu = (char)('A' + (i + j) % 26);
                        Console.Write(betu);
                    }
                    Console.WriteLine();
                }
            }
            static void f42()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];
                int paratlanDb = 0;

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                    if (szamok[i] % 2 != 0)
                    {
                        paratlanDb++;
                    }
                }

                Console.WriteLine($"A páratlan számok darabszáma: {paratlanDb}");
            }

            static void f43()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];
                int parosOsszeg = 0;

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                    if (szamok[i] % 2 == 0)
                    {
                        parosOsszeg += szamok[i];
                    }
                }

                Console.WriteLine($"A páros számok összege: {parosOsszeg}");
            }

            static void f44()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                }

                Console.WriteLine("Páros számok a beolvasás sorrendjében:");
                for (int i = 0; i < n; i++)
                {
                    if (szamok[i] % 2 == 0)
                    {
                        Console.WriteLine($"{i + 1}. szám: {szamok[i]}");
                    }
                }
            }

            static void f45()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                }

                int keresett = EgeszSzamBeker("Add meg a keresett számot: ");
                int index = -1;

                for (int i = 0; i < n; i++)
                {
                    if (szamok[i] == keresett)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    Console.WriteLine($"A(z) {keresett} szám előfordul a tömbben, indexe: {index}");
                }
                else
                {
                    Console.WriteLine($"A(z) {keresett} szám nem található a tömbben.");
                }
            }

            static void f46()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                }

                int keresett = EgeszSzamBeker("Add meg a keresett számot: ");
                int db = 0;

                for (int i = 0; i < n; i++)
                {
                    if (szamok[i] == keresett)
                    {
                        db++;
                    }
                }

                Console.WriteLine($"A(z) {keresett} szám {db} alkalommal fordul elő a tömbben.");
            }

            static void f47()
            {
                int n = EgeszSzamBeker("Add meg a tanulók számát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A tanulók száma nem lehet 0 vagy negatív!");
                    return;
                }

                string[] nevek = new string[n];

                Console.WriteLine($"Olvass be {n} nevet:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}. név: ");
                    nevek[i] = Console.ReadLine();
                }

                Console.Write("Add meg a keresett nevet: ");
                string keresettNev = Console.ReadLine();
                int db = 0;

                for (int i = 0; i < n; i++)
                {
                    if (nevek[i].Equals(keresettNev, StringComparison.OrdinalIgnoreCase))
                    {
                        db++;
                    }
                }

                Console.WriteLine($"A(z) '{keresettNev}' név {db} alkalommal fordul elő az osztályban.");
            }

            static void f48()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                }

                if (n == 1)
                {
                    Console.WriteLine("Csak egy szám van, a különbség 0.");
                    return;
                }

                int min = szamok[0];
                int max = szamok[0];

                for (int i = 1; i < n; i++)
                {
                    if (szamok[i] < min)
                        min = szamok[i];
                    if (szamok[i] > max)
                        max = szamok[i];
                }

                int kulonbseg = max - min;
                Console.WriteLine($"A legkisebb szám: {min}");
                Console.WriteLine($"A legnagyobb szám: {max}");
                Console.WriteLine($"A különbség: {kulonbseg}");
            }

            static void f49()
            {
                int n = EgeszSzamBeker("Add meg a számok darabszámát: ");
                if (n <= 0)
                {
                    Console.WriteLine("A darabszám nem lehet 0 vagy negatív!");
                    return;
                }

                int[] szamok = new int[n];

                Console.WriteLine($"Olvass be {n} számot:");
                for (int i = 0; i < n; i++)
                {
                    szamok[i] = EgeszSzamBeker($"{i + 1}. szám: ");
                }

                for (int i = n - 1; i >= 1; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (szamok[j] > szamok[j + 1])
                        {
                            int temp = szamok[j];
                            szamok[j] = szamok[j + 1];
                            szamok[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("A számok növekvő sorrendben:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(szamok[i]);
                    if (i < n - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            static void Main(string[] args)
            {




                Console.WriteLine("Minden feladat lefutott. Nyomj meg egy gombot a kilépéshez.");
            }



        }
    }
}
