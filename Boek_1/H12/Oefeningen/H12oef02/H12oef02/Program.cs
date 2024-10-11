using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H12oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            //consolekleuren instellen
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Declaratie
            string volledigLijn;
            string[] lijnGesplit;
            string maand, maandVorige = "", dag, dagVorige = "";
            decimal gemiddelde;
            int maandAantal, dagAantal, maandTotaal, dagTotaal, bezetting;
            DateTime tijd;

            // Streamreader starten
            StreamReader streamLees = new StreamReader("H12OEF02.txt");
            
            // Titel afdrukken
            Console.WriteLine("Bezetting labo");
            Console.WriteLine("--------------");
            Console.WriteLine();

            // Zet alle tellers op nul
            maandAantal = 0;
            maandTotaal = 0;
            dagAantal = 0;
            dagTotaal = 0;

            // We lopen door onze records...
            while (streamLees.Peek() != -1)
            {
                // Lees eerste/volgende record
                volledigLijn = streamLees.ReadLine();
                lijnGesplit = volledigLijn.Split(',');

                // Bewaren de dag (datum) en bezetting in variabelen
                dag = lijnGesplit[0].Trim('#');
                bezetting = Convert.ToInt16(lijnGesplit[2]);

                // Console.WriteLine(dag);

                // Groep dag
                // Als het een andere dag is...
                if (dagVorige != dag)
                {
                    // Druk het gemiddelde per dag af (enkel eerste record niet!)
                    if (!String.IsNullOrEmpty(dagVorige))
                    {
                        // 2X deze code => ook na de lus!
                        gemiddelde = dagTotaal / Convert.ToDecimal(dagAantal);
                        tijd = DateTime.Parse(dagVorige);
                        Console.WriteLine(tijd.ToShortDateString() + ": " + Math.Round(gemiddelde, 2, MidpointRounding.AwayFromZero).ToString("F2"));

                        // Tellers dag op nul !!
                        dagAantal = 0;
                        dagTotaal = 0;
                    }
                    // Vorige dag bijhouden
                    dagVorige = dag;
                }

                // Groep maand
                // Als het een andere maand is...
                maand = dagVorige.Substring(5, 2);

                if (maandVorige != maand)
                {
                    // Druk het gemiddelde per maand af (enkel eerste record niet!)
                    if (!String.IsNullOrEmpty(maandVorige))
                    {
                        // 2X deze code => ook na de lus!
                        gemiddelde = maandTotaal / Convert.ToDecimal(maandAantal);
                        Console.WriteLine("Maand " + maandVorige + ": " + Math.Round(gemiddelde, 2, MidpointRounding.AwayFromZero).ToString("F2"));
                        Console.WriteLine();

                        // Tellers dag op nul !!
                        maandAantal = 0;
                        maandTotaal = 0;
                    }
                    // Vorige dag bijhouden
                    maandVorige = maand;
                }

                // Zelfde dag...
                dagTotaal += bezetting;
                dagAantal++;

                // Zelfde maand...
                maandTotaal += bezetting;
                maandAantal++;
            }

            // Na de lus de afsluitcode (2X)

            // 2X deze code => ook na de lus!
            gemiddelde = dagTotaal / Convert.ToDecimal(dagAantal);
            tijd = DateTime.Parse(dagVorige);
            Console.WriteLine(tijd.ToShortDateString() + ": " + Math.Round(gemiddelde, 2, MidpointRounding.AwayFromZero).ToString("F2"));

            // 2X deze code => ook na de lus!
            gemiddelde = maandTotaal / Convert.ToDecimal(maandAantal);
            Console.WriteLine("Maand " + maandVorige + ": " + Math.Round(gemiddelde, 2, MidpointRounding.AwayFromZero).ToString("F2"));

            // Sluit het bestand
            streamLees.Close();
            streamLees.Dispose();

            // Wachten op enter
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Druk op enter om te eindigen.");
            Console.ReadLine();
        }
    }
}
