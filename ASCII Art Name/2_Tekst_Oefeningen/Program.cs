using System;
using System.IO;

namespace _2_Tekst_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {

            // Oefening 2.1 ASCII Art
            /*
            String myName = @"
            __        _____  _   _ _____ _____ ____  
            \ \      / / _ \| | | |_   _| ____|  _ \ 
             \ \ /\ / / | | | | | | | | |  _| | |_) |
              \ V  V /| |_| | |_| | | | | |___|  _ < 
               \_/\_/  \___/ \___/  |_| |_____|_| \_\
                                         
             ";

            Console.WriteLine(myName);
            */
            ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"__        _____  _   _ _____ _____ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"____");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"\ \      / / _ \| | | |_   _| ____");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"|  _ \");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@" \ \ /\ / / | | | | | | | | |  _| ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"| |_) |");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  \ V  V /| |_| | |_| | | | | |___");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"|  _ <");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"   \_/\_/  \___/ \___/  |_| |_____");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"|_| \_\");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n\n");

            // Oefening  2.2. STRING INTERPOLATIE, 2 vorige oefeningen aanpassen
            // Oefening 1.5. Kill/Death-ratio
            Console.WriteLine("2.1. (1.5) Kill/Death-ratio INTERPOLATED\n");

            double kills = 879952;
            double deaths = 5002;

            double ratio = kills / deaths;

            //   Console.WriteLine("Kill {0} / Death {1} ratio = {2}\n", kills, deaths, ratio);
            Console.WriteLine($"Kill {kills} / Death {deaths} ratio = {ratio}\n");

            //Oefening 1.6 Gewicht in space
            Console.WriteLine("2.2 (1.6) Gewicht in space INTERPOLATED\n");

            double massa = 70.5; // == 70,5kg

            double mercurius = 0.38 * massa;
            double venus = 0.91 * massa;
            double aarde = 1.00 * massa;
            double mars = 0.38 * massa;
            double jupiter = 2.34 * massa;
            double saturnus = 1.06 * massa;
            double uranus = 0.92 * massa;
            double neptunus = 1.19 * massa;
            double pluto = 0.06 * massa;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"Je weegt op Mercurius {mercurius}kg\n");
            Console.Write($"Je weegt op Venus {venus}kg\n");
            Console.Write($"Je weegt op Aarde {aarde}kg\n");
            Console.Write($"Je weegt op Mars {mars}kg\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"Je weegt op Jupiters {jupiter}kg\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"Je weegt op Saturnus {saturnus}kg\n");
            Console.Write($"Je weegt op Uranus {uranus}kg\n");
            Console.Write($"Je weegt op Neptunus {neptunus}kg\n");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"Je weegt op Pluto {pluto}kg\n");
            Console.BackgroundColor = ConsoleColor.Black;

            //Oefening 2.3 PRO_Deel2_HardDiskInfo (geheugen:Environment.WorkingSet; )
            Console.WriteLine("\n2.3 PRO Deel2: HardDiskInfo\n");

            Console.WriteLine("Over welke Drive wenst u info te krijgen? (1 of 2 of 3)");
            int drive = Convert.ToInt32(Console.ReadLine());
            drive--;
            Console.WriteLine($"Drivenummer {drive} is gekozen...\n");

            long cdriveingbytes = DriveInfo.GetDrives()[drive].AvailableFreeSpace / 1073741824;
            long totalsize = DriveInfo.GetDrives()[drive].TotalSize / 1073741824;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Drive {drive} is {totalsize} GB groot, en er is {cdriveingbytes} GB vrij ruimte beschikbaar.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to continue to next solution..");

            Console.ReadKey();
            Console.Clear();

            //Oefening 2.4 PRO_Deel2_Weerstandsberekening_1
            Console.WriteLine("2.4 PRO Deel2: Weerstandsberekening 1 + Pro\n");

            Console.WriteLine("\nWelk de waarde van ring1? [0-9]");
            int ring1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nWelk de waarde van ring2? [0-9]");
            int ring2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nWelk de waarde van ring3? [0-9]");
            int ring3 = Convert.ToInt32(Console.ReadLine());

            double resistanceValue = (ring1 * 10 + ring2) * Math.Pow(10, ring3);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nTotal resistance value is: {resistanceValue} Ohm\n");
            Console.ForegroundColor = ConsoleColor.White;


            //Oefening 2.5 PRO_Deel2_Weerstandsberekening_2
            Console.WriteLine("\n2.5 PRO Deel2: Weerstandsberekening 2\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"   ╔═══════════════════════════════════════════╗");
            Console.Write(@"───║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  Total resistance value is: {resistanceValue} Ohm");
            Console.SetCursorPosition(47, 18);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"║───");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine(@"   ╚═══════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            //Oefening 2.6 PRO_Deel3_Weerstandsberekening_3
            Console.WriteLine("\n2.6 PRO Deel3: Weerstandsberekening 3\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"   ╔════════════════╗");
            Console.Write(@"───║");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"   ");
            //double resistanceValue = (ring1 * 10 + ring2)* Math.Pow(10, ring3);

            if (ring1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (ring1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (ring1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (ring1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (ring1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (ring1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ring1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (ring1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (ring1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (ring1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.Write($" {ring1} ");

            if (ring2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (ring2 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (ring2 == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (ring2 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (ring2 == 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (ring2 == 5)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ring2 == 6)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (ring2 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (ring2 == 8)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (ring2 == 9)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.Write($" {ring2} ");
            if (ring3 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (ring3 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (ring3 == 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (ring3 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (ring3 == 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (ring3 == 5)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ring3 == 6)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (ring3 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (ring3 == 8)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (ring3 == 9)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.Write($" {ring3} ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 24);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"║───");
            Console.SetCursorPosition(0, 25);
            Console.WriteLine(@"   ╚════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nPress any key to continue to next solution..");
            Console.ReadKey();
            Console.Clear();

            //Oefening 2.7 PRO_Shell-starter
            Console.WriteLine("\n2.7 PRO Shell-Starter (in Progress)\n");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.Arguments = "/all";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process

            // Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd(); //normal output
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd(); //error output (if any)
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");

            Console.ReadKey();
        }
    }
}
