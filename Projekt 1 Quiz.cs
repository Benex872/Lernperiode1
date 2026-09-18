Console.WriteLine("===== TRUE OR FALSE QUIZ =====");

int points = 0;
int numberOfQuestions;

// Benutzer wählt Anzahl Fragen
do
{
    Console.Write("Wie viele Fragen möchtest du spielen? (1-10): ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out numberOfQuestions))
    {
        Console.WriteLine("Ungültige Eingabe! Bitte gib eine Zahl von 1 bis 10 ein.");
        numberOfQuestions = 0;
    }
    else if (numberOfQuestions < 1 || numberOfQuestions > 10)
    {
        Console.WriteLine("Die Anzahl muss zwischen 1 und 10 liegen!");
    }

} while (numberOfQuestions < 1 || numberOfQuestions > 10);


// Frage 1
if (numberOfQuestions >= 1)
{
    bool answer; // a bool because answers can only be true or false

    do
    {
        Console.Write("1. Ist die Erde ein Planet? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 2
if (numberOfQuestions >= 2)
{
    bool answer;

    do
    {
        Console.Write("2. Ist die Sonne ein Planet? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == false)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 3
if (numberOfQuestions >= 3)
{
    bool answer;

    do
    {
        Console.Write("3. Ist Wasser bei normalem Druck bei 100°C am Siedepunkt? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 4
if (numberOfQuestions >= 4)
{
    bool answer;

    do
    {
        Console.Write("4. Hat ein Mensch normalerweise zwei Herzen? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == false)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 5
if (numberOfQuestions >= 5)
{
    bool answer;

    do
    {
        Console.Write("5. Ist 10 größer als 5? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 6
if (numberOfQuestions >= 6)
{
    bool answer;

    do
    {
        Console.Write("6. Ist der Mond größer als die Erde? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == false)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 7
if (numberOfQuestions >= 7)
{
    bool answer;

    do
    {
        Console.Write("7. Ist 2 + 2 = 4? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 8
if (numberOfQuestions >= 8)
{
    bool answer;

    do
    {
        Console.Write("8. Ist ein Elefant kleiner als eine Maus? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == false)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 9
if (numberOfQuestions >= 9)
{
    bool answer;

    do
    {
        Console.Write("9. Hat eine Woche 7 Tage? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Frage 10
if (numberOfQuestions >= 10)
{
    bool answer;

    do
    {
        Console.Write("10. Ist die Schweiz in Europa? (true/false): ");
        string input = Console.ReadLine();

        if (bool.TryParse(input, out answer))
        {
            break;
        }

        Console.WriteLine("Ungültige Eingabe! Bitte gib true oder false ein.");

    } while (true);

    if (answer == true)
    {
        Console.WriteLine("Richtig!");
        points++;
    }
    else
    {
        Console.WriteLine("Falsch!");
    }
}


// Ergebnis
Console.WriteLine();
Console.WriteLine("===== ERGEBNIS =====");
Console.WriteLine("Du hast " + points + " von " + numberOfQuestions + " Punkten erreicht!");

if (points == numberOfQuestions)
{
    Console.WriteLine("Perfekt! Alle Fragen richtig!");
}
else if (points >= numberOfQuestions / 2)
{
    Console.WriteLine("Gut gemacht!");
}
else
{
    Console.WriteLine("Du kannst noch etwas üben!");
}
