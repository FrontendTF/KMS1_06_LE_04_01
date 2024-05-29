using System;
using System.Collections.Generic;
using GeometrischeFigurenBerechnung;

class Men�
{
    private List<GeometrischeFigur> figurenListe = new List<GeometrischeFigur>();

    public void Start()
    {
        ///<summary>
        /// Men� + automatische Speicherung/Ausgabe der Objekte bei der Erstellung
        while (true)
        {
            Console.Clear();
            Console.WriteLine("W�hlen Sie eine geometrische Figur:");
            Console.WriteLine("1 f�r Kreis");
            Console.WriteLine("2 f�r Rechteck");
            Console.WriteLine("3 f�r Dreieck");
            Console.WriteLine("4 f�r Beenden");
            string auswahl = Console.ReadLine();

            if (auswahl == "4")
            {
                Environment.Exit(0);
            }

            GeometrischeFigur figur = null;

            switch (auswahl)
            {
                case "1":
                    figur = FigurenErstellung.ErstelleKreis();
                    break;
                case "2":
                    figur = FigurenErstellung.ErstelleRechteck();
                    break;
                case "3":
                    figur = FigurenErstellung.ErstelleDreieck();
                    break;
                default:
                    Console.WriteLine("Ung�ltige Auswahl, dr�cken Sie eine Taste f�r eine erneute Eingabe.");
                    Console.ReadKey();
                    continue;
            }

            // Speicherung der Objekte/Instanzen
            if (figur != null)
            {
                figurenListe.Add(figur);
                Console.WriteLine($"Figur: {figur.GetType().Name}, Farbe: {figur.Farbe}");
                Console.WriteLine($"Fl�che: {figur.BerechneFlaeche():F2} m�");
                Console.WriteLine($"Umfang: {figur.BerechneUmfang():F2} m");
                /// Readkey eingebaut um das Ergebnis anzusehen k�nnen, 
                /// ohne dem w�rde er im Men� mit continue dem user keine Zeit geben sich die Ergebnise anzusehen
                Console.WriteLine("Dr�cken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
            }
        }
        ///<summary/>

        Console.Clear();
    }
}
