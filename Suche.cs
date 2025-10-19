using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static sortieren.Daten; // entspricht dem Dateinamen ohne ".cs"

namespace sortieren
{
    internal class Suche
    {
        private string[] vornamen;

        // Konstruktor: übernimmt Daten aus der anderen Datei
        public Suche()
        {
            // Array aus der Datei übernehmen
            vornamen = daten;
            // Sortieren für binäre Suche
            Array.Sort(vornamen, StringComparer.OrdinalIgnoreCase);
        }

        public bool LineareSuche(string name)
        {
            foreach (string n in vornamen)
            {
                if (string.Equals(n, name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        public bool BinaereSuche(string name)
        {
            int links = 0;
            int rechts = vornamen.Length - 1;

            while (links <= rechts)
            {
                int mitte = (links + rechts) / 2;
                int vergleich = string.Compare(vornamen[mitte], name, StringComparison.OrdinalIgnoreCase);

                if (vergleich == 0)
                    return true;
                else if (vergleich < 0)
                    links = mitte + 1;
                else
                    rechts = mitte - 1;
            }
            return false;
        }
    }
}
