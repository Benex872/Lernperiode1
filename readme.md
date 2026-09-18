# Lern-Periode 1

28.8 bis ?

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
2. Was wäre ein geeignetes Projekt für diese LP1? Ein Quiz programm mit true und false antworten.

## 28.8.2026

Heute habe ich 3 verschiedene Programme geschrieben das erste wart ein Zahlen eraten Progeamm in dem mir das programm sagte ob es höher oder tiefer war bis ich die Zahl eraten.Das 2te Programm war ein Noten berechne in dem ich meine ereichte Punktzahl eingeben konnte und die Max punktzahl und die Note berechnet wurde falls ich mehr punkte ereicht habe als Max hat mir das Programm gratuliert und eine 6+ gegeben. Mein 3tes Programm war ein Quiz mit True und False dort habe ich auch gelernt wie ich etwas zu bool konvertiere.

## 4.9.2026

- [x] Eine Schleife programmieren, die etwas so oft wiederholt, wie der Benutzer angibt.
- [ ] Ein Quiz programmieren, das dem Benutzer so viele Fragen stellt, wie er möchte.
- [ ] Herausfinden, wie ein Programm automatisch eigene Fragen erstellen kann.

Heute habe ich eine Schleife programmiert die etwas so oft wiederholt, wie der Benutzer angibt.
ich habe es leider nicht geschafft ein Quiz zu Programmieren das dem Benutzer so viele Fragen stellt, wie er möchte.

## 11.9.2026
- [x] Eine Datenbank erstellen in denen ich 10 Quiz fragen speichern kann und die zu einer Nummer speicher.
- [x] Das Programm soll den Benutzer fragen wie viele Fragen er haben will in seinem Quiz.
- [x] Das der Benutzer eingeben kann wie viele Fragen er will und sie im auch gestellt werden.
- [x] Herausfinden, wie ein Programm automatisch eigene Fragen erstellen kann.

Heute habe ich an meinen Arbeitspaketen gearbeitet und heraus gefunden wie ich eine Datenbank erstellen kann in denn ich Fragen speichern kann und sie jederzeit aufrufen kann. Ich habe auch gelernt wie ich ein Programm schreiben kann das automatisch Fragen generiert und diese mir stellt.

## 18.9.2026
- [ ] Taschenrechner programmieren.
- [ ] Altersrechner programmieren.
- [x] Array mit Noten ( _Hausaufgabe_ )
 Ich habe die Hausaufgaben zuhause gemacht und ich habe mit den Arrays Noten gespeichert und der Benutzer kann sagen was die maximale Punkte waren und seine ereichten Punkte und das gab dann eine Note. 

## Zussamenfassung von meinem Quiz Projekt

Das Programm ist ein True-or-False-Quiz, das in C# programmiert wurde. Der Benutzer kann zuerst auswählen, wie viele Fragen er beantworten möchte. Dabei kann er zwischen 1 und 10 Fragen auswählen. Gibt er beispielsweise 11 ein, sagt das Programm, dass die Zahl zwischen 1 und 10 liegen muss, und fragt erneut nach einer Eingabe.

Für die Punkte wird eine int-Variable namens points verwendet. int steht für eine ganze Zahl. Die Antworten werden mit bool gespeichert. Ein bool kann nur true oder false sein, deshalb eignet er sich gut für ein True-or-False-Quiz.

Mit Console.WriteLine() gibt das Programm Text auf dem Bildschirm aus und mit Console.ReadLine() liest es die Eingabe des Benutzers ein. Mit TryParse wird überprüft, ob die Eingabe gültig ist. Wenn der Benutzer zum Beispiel etwas anderes als true oder false eingibt, wird eine Fehlermeldung angezeigt und er kann die Antwort erneut eingeben.

Das Programm verwendet auch if und else. if bedeutet „wenn“ und überprüft eine Bedingung. Wenn die Bedingung stimmt, wird der Code im if ausgeführt. Wenn sie nicht stimmt, wird der Code im else ausgeführt. Bei einer richtigen Antwort wird mit points++ die Punktzahl um 1 erhöht.

Für die Eingabe der Anzahl der Fragen und für ungültige Antworten wird eine do-while-Schleife verwendet. Eine do-while-Schleife führt den Code zuerst einmal aus und überprüft danach die Bedingung. Dadurch kann das Programm so lange nach einer neuen Eingabe fragen, bis der Benutzer eine gültige Eingabe macht.

Am Ende zeigt das Programm an, wie viele Punkte der Benutzer erreicht hat. Dadurch verbindet das Programm mehrere wichtige C#-Grundlagen wie Variablen, int, bool, if/else, do-while, Benutzereingaben und Bedingungen.
