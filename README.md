# Lernbericht
# Lern-Bericht
Angel Angelov

## Einleitung

Ich habe ein Zufallszahl Spiel programiert, indem man Zahlen von 1 bis 100 generiert. 

## Was habe ich gelernt?

Ich habe gelernt, wie man while brachen kann um prozesse zu wiederhollen, bis man die Schleifenbedingung erfühlt.

## Beschreibung



Ich habe ein Zufallszahlspiel programmiert indem ich viele Variablen benutzt habe wie int string und bool, Natürlich habe ich auch viele Operationen gebraucht, wie Console.WriteLine/ReadLine und andere. Am meistens hatte ich Schwierigkeiten mit Funktionen, weil die für mich etwas sehr neues wahren. Mit While kann man eine Schleife beschreiben, die so lange durchlaufen wird, bis man Schleifenbedingung wahr/true ergibt. Da habe ich das so eingesetzt, indem ich den Schleifenbedingung eingabe != Zahl gegeben habe. Das bedeutet das während meine Eingabe und den Zufälligen generierten Zahl nicht Gleich sind, sollte sich wiederholen.(unten sehen sie ein Beispiel von mein Code)


```csharp




                while (eingabe != Zahl)
                {
                    ana++;
                    while (check == false)
                    {
                        try
                        {
                            eingabe = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.WriteLine("Geben sie bitte nur Zahlen ein");
                            check = false;
                        }
                    }
                    check = false;


```

![image](https://user-images.githubusercontent.com/112430127/189852079-968bf222-2a5a-45e4-8e00-729ee8174ded.png)
- Da ist eine Bild von mein Zufallszahlspiel Console. 

                   
                   
## Verifikation

Ich habe ein Text  über die Funktionen  geschrieben, die ich gebraucht habe und dann habe ich ein Beispiel(Code) eingefügt. Als letztes habe ich eine Bild eingefügt und sie mit ein Satz beschrieben.
# Reflektion zum Arbeitsprozess

Was lief gut:
- Ich habe jetz viel mehr Ahnung, wie man programiert.

Was lief nicht so gut:
- Ich habe mich von unnötige Sachen abgelegt und so Zeit verloren/ verschwendet. Meiner Planung war auch nicht so gut, weil ich schlecht geplant habe und mich nicht am Plan gehalten habe.
**VBV**: 
. Konzentriert arbeiten und sich nicht ablenken und auch am Plan halten.
