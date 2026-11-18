string? neueAufgabe = null;
List<string> aufgaben = new();
int hinzufügen_frage = 0;
int auswahl = 0;



while (auswahl != 4){

Console.WriteLine("=========================");
Console.WriteLine("Personal Dashboard");
Console.WriteLine("=========================");
Console.WriteLine("1 - Aufgabe hinzufügen");
Console.WriteLine("2 - Aufgaben anzeigen");
Console.WriteLine("3 - Aufgabe löschen");
Console.WriteLine("4 - Beenden"); 

Console.Write("Deine Auswahl: ");
auswahl = Convert.ToInt32(Console.ReadLine());

while(auswahl <1 || auswahl > 4) //erste abfrage, wenn eingabe nicht 1-4 dann nochmal fragen
{
    Console.Write("Deine Auswahl: ");
    auswahl = Convert.ToInt32(Console.ReadLine());
}
switch (auswahl)    //switch (weiche), "alternative" zu if, in dem Fall besser + break; nicht vergessen!
{
    case 1:
        Console.Write("Aufgabe hinzufügen: ");
        neueAufgabe = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(neueAufgabe))
        {
            Console.WriteLine("Möchtest du " + neueAufgabe + " als Aufgabe hinzufügen?");
            Console.WriteLine("[1] Ja [2] Nein");
            hinzufügen_frage = Convert.ToInt32(Console.ReadLine());
            if(hinzufügen_frage == 1)
            {
                aufgaben.Add(neueAufgabe);
                Console.WriteLine(neueAufgabe + " wurde den Aufgaben hinzugefügt.");
            }
            else
            {
                Console.WriteLine("Die Aufgabe wurde nicht hinzugefügt.");
            }
        }

        break;
    case 2:
        Console.WriteLine("Aufgaben anzeigen");
        Console.WriteLine("\nDeine Aufgaben sind: " );
        
        if (aufgaben.Count == 0)
        {
            Console.WriteLine("Es wurden noch keine Aufgaben hinzugefügt.");
        }
        else
        {
            foreach(string aufgabe in aufgaben)
            {
                Console.WriteLine("- " + aufgabe);
            }
            System.Console.WriteLine("press any key to continue: ");
            Console.ReadLine();
        }

        break;
    case 3:
        Console.WriteLine("Aufgabe löschen");

        break;
    case 4:
        Console.WriteLine("Beenden");
        break;
    default:
    Console.WriteLine("Gib eine gültige Zahl ein!");
    break;
}
}


