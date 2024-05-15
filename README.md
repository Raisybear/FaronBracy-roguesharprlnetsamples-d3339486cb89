# Übersicht

Dieses Projekt handelt um einen RPG, Diesen RPG haben wir schon vorgebaut von ... kopiert und mit unseren Eigenen Funktionen erweitert.

[Hier ist dies ersichtlich](https://bitbucket.org/FaronBracy/roguesharprlnetsamples/downloads/?tab=branches)

## Additional Resources

- [Creating a Rougelike Game in C#](http://roguesharp.wordpress.com/ "Creating a Roguelike Game in C#")
- [RLNET Tutorials](https://clarktravism.wordpress.com/ "RLNET Tutorials")
  - [RLNET source code](https://bitbucket.org/clarktravism/rlnet "RLNET Source")
  - [RLNET license](https://bitbucket.org/clarktravism/rlnet "RLNET License")
- [RogueBasin](http://www.roguebasin.com/ "RogueBasin")
  - [Articles of interest for Roguelike developers](http://www.roguebasin.com/index.php?title=Articles "Roguelike developer articles")

## License

#### RogueSharp RLNET Samples

The MIT License (MIT)

Copyright (c) 2015 Faron Bracy

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

---

# Projekt-Dokumentation

**Gruppe:**

- Spycher Elias
- Sacher Robin
- Hitz Julian

| Datum      | Version | Zusammenfassung                                                                                   |
| ---------- | ------- | ------------------------------------------------------------------------------------------------- |
| 08.03.2024 | 1.0.0   | Das Projekt wurde auf Github hochgeladen. Userstories geschrieben, Testfälle erstellt             |
| 15.03.2024 | 1.0.1   | Dragon als Monster hinzugefügt, Neustart des Spiels nach dem Tod, Arbeitspakete, Use Case Diagramm |
| 22.03.2024 | 1.0.2   | Sound Design hinzugefügt, Shop ist implementiert, noch nicht funktionsfähig, Poison implementiert, noch nicht funktionsfähig.  |
| 05.04.2024 | 1.1.0   | Sound Design vielfältig erweiterrt, Shop weiter entwickelt, Poison weiter implementiert, Beides noch nicht vollständig Funktionsfähig     |
| 26.04.2024 | 1.2.0   | Viele Fehler behoben, Shop fertiggestellt, Poison weiterentwickelt, noch nicht fertig.                                                                                                  |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt erweitern wir ein RPG Game. Dies wird in Visual Stduio 2022 umgesetzt. Wir ändern die Grundfunktion des Spiels nicht, aber wir fügen neue Monster, Abilities, Balance Changes, Sounds und vieles Mehr hinzu.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                                                                    |
| ---- | --------------- | ---------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| 1.1  | Muss            | Funktional | Als User möchte ich eine Benachrichtigung erhalten, wenn ich keine Leben mehr habe, damit ich weiss, dass ich verloren habe.                    |
| 2.1  | Muss            | Funktional | Als User möchte ich, dass die Steuerungstasten w,a,s,d statt Pfeiltasten sind, damit ich meine Figur steuern kann.                              |
| 3.1  | Muss            | Funktional | Als User möchte ich, dass die Spielfigur 25 statt 100 Lebenspunkte hat, damit man weniger überlebt                                              |
| 4.1  | Muss            | Funktional | Als User möchte ich, dass ich nach jedem Benutzen der Treppe um 10 Lebenspunkte geheilt werde, damit ich nicht am Anfang des Spiels sterbe.     |
| 5.1  | Kann            | Qualität   | Als User möchte ich, dass mir kurz erklärt wird, was die Items machen, um zu wissen für was ich diese Verwenden kann.                           |
| 6.1  | Kann            | Qualität   | Als User möchte ich, dass es eine Storyline gibt, um zu wissen warum ich in dem Dungeon bin.                                                    |
| 7.1  | Muss            | Funktional | Als User möchte ich, dass nach 10 Levels, den Endboss bekämpfen muss, um das Spiel zu Beenden                                                   |
| 7.2  | Muss            | Funktional | Als User möchte ich einen Drachen im Spiel haben, der als Endboss dient, damit ich ein schwieriges Ende habe.                                   |
| 8.1  | Kann            | Funktional | Als User möchte ich einen Shop haben, um mein Gold verwenden zu können                                                                          |
| 8.2  | Kann            | Funktional | Als User möchte ich im Shop ein Heiltrank kaufen können, um mich zu heilen                                                                      |
| 8.3  | Kann            | Funktional | Als User möchte ich, dass man zufällige schon implementierte Items im Shop kaufen kann, um stärker zu werden.                                   |
| 9.1  | Muss            | Funktional | Als User möchte ich, dass es ab dem Level 5 Fallen auf der Map gibt, um ein weiteres Hinderniss zu haben.                                       |
| 10.1 | Kann            | Funktional | Als User möchte ich, dass eine Gift Fähigkeit gibt, damit ich die Gegner besser besiegen kann.                                                  |
| 11.1 | Kann            | Funktional | Als User möchte ich, dass es eine Falle gibt, die Lebenspunkte abzieht, damit es schwieriger wird.                                              |
| 12.1 | Kann            | Funktional | Als User möchte ich, dass es eine Falle gibt, die meine Spielfigur für zwei Runden bewegungsunfähig macht, damit es schwieriger wird.           |
| 13.1 | Kann            | Funktional | Als User möchte ich, dass es eine kleine Chance gibt, dass ich mit einem Angriff extra Schaden machen kann, damit die Kämpfe spannender werden. |
| 14.1 | Kann            | Funktional | Als User möchte ich, Sounds im Spiel haben wenn ich Türen betrete, Treppen hochgehe, Monster töte etc, damit mein Spielerlebniss Intensiver ist.                                                                                                                                                |



### 1.3 Testfälle

| TC-№  | Ausgangslage                                     | Eingabe                                                                              | Erwartete Ausgabe                                                      |
| ----- | ------------------------------------------------ | ------------------------------------------------------------------------------------ | ---------------------------------------------------------------------- |
| 1.1   | Spiel gestartet und Leben <= 0                   |                                                                                      | Du hast all deine Leben verloren                                       |
| 2.1   | Spiel gestartet                                  | W                                                                                    | Spieler bewegt sich auf der X-Achse nach oben                          |
| 2.2   | Spiel gestartet                                  | A                                                                                    | Spieler bewegt sich auf der Y-Achse nach links                         |
| 2.3   | Spiel gestartet                                  | S                                                                                    | Spieler bewegt sich auf der X-Achse nach unten                         |
| 2.4   | Spiel gestartet                                  | D                                                                                    | Spieler bewegt sich auf der Y-Achse nach rechts                        |
| 3.1   | Spiel nicht gestartet                            | Spiel starten                                                                        | Lebensanzeige oben rechts mit dem Wert 25 Leben                        |
| 4.1   | Spiel gestartet                                  | Treppe nach oben laufen                                                              | Leben wird um 15 Leben erhöht                                          |
| 5.1   | Spiel gestartet                                  | Ein Item wird aufgenommen                                                            | Text auf der Konsole, welcher Fähigkeiten des Items beschreibt         |
| 6.1   | Spiel nicht gestartet                            | Spiel wird gestartet                                                                 | Kurzes Intro welches den Einstieg und die Story in das Spiel schildert |
| 7.1.1 | Spiel gestartet und Spielfortschritt im 10 Level | Kampf gegen den Endboss                                                              | Sieg gegen den Endboss, Spiel wird beendet                             |
| 7.2.1 | Spiel gestartet und Spielfortschritt im 10 Level | Kampf gegen den Endboss                                                              | Mehr Schaden gegen den Spieler als normale Gegner                      |
| 8.1.1 | Spiel gestartet und im Shopmenu                  | Auswahl eines Items und Kauf des ausgewählten Items                                  | Gold wird um den bezahlten Betrag abgezogen                            |
| 8.2.1 | Spiel gestartet und im Shopmenu                  | Auswahl des Heiltranks und Kauf des Heiltranks                                       | Heiltrank wird dem Inventar hinzugefügt                                |
| 8.3.1 | Spiel gestartet und im Shopmenu                  | Auswahl eines durch Zufall im Shop angebotenem Items und Kauf des ausgewählten Items | Das Item wird dem Inventar hinzugefügt                                 |
| 9.1   | Spiel gestartet und erreichen des 5ten Levels    | Eine Falle wird ausgelöst                                                            | dem Spieler werden 5 Lebenspunkte abgezogen                            |
| 10.1  | Gift Fähigkeit erhalten                          | Gift Fähigkeit aktiviert                                                             | Gifteffekt um Spieler                                                  |
| 11.1  | Level 5 betreten                                 | In Schadensfalle hineingelaufen                                                      | Lebensabzug                                                            |
| 12.1  | Level 5 betreten                                 | In Betäubungsfalle hineingelaufen                                                    | Betäubt für 2 Runden                                                   |
| 13.1  | Gegner angegriffen                               | Bewegungstaste in die Richtug des Gegners                                            | Schaden + 2                                                            |
| 14.1.1  | Gegner getötet                                 | -                                                                                    | Sound für das Moster töten wird abgespielt                             |
| 14.1.2  | Spiel gestartet                                | Button für Magic Map                                                                 | Sound für die Magic Map wird abgespielt                                |
| 14.1.3  | Spiel gestartet                                | W/A/S/D                                                                              | Spielsoundtrack wird abgespielt.                                       |
| 14.1.4  | Spiel gestartet                                | In das nächste level mit .                                                           | Sound für das Betreten eines neuen Levels wird abgespielt              |



### 1.4 Diagramme

![RPG Game](https://github.com/Raisybear/LA1304RPG/assets/110891559/bbf4da93-7f0f-4336-983f-4b87f9a1b8ba)

## 2 Planen

| AP-№  | Frist      | Zuständig     | Beschreibung                                         | geplante Zeit |
| ----- | ---------- | ------------- | ---------------------------------------------------- | ------------- |
| 1.1.A | 26.04.2024 | Elias Spycher | Implementierung des Todes, des Heros                 | 90'           |
| 2.1.B | 26.04.2024 | Elias Spycher | Bedienung des Characters von Pfeiltasten auf W A S D | 45'           |
| 3.1.C | 26.04.2024 | Robin Sacher  | Einstellung der HP                                   | 10'           |
| 4.1.D | 26.04.2024 | Robin Sacher  | Healing bei Betreten von neuem Level                 | 30'           |
| 5.1.E | 26.04.2024 | Elias Spycher | Items Erklärungen                                    | 45'           |
| 6.1.F | 26.04.2024 | Elias Spycher | Story wird erklärt                                   | 45'           |
| 7.1.G | 26.04.2024 | Robin Sacher  | Implementierung des Drachen als Endboss              | 45'           |
| 7.2.H | 26.04.2024 | Robin Sacher  | Implementierung des Drachen als Endboss              | 45'           |
| 8.1.I | 26.04.2024 | Robin Sacher  | Implementierung Shop                                 | 45'              |
| 8.1.J | 26.04.2024 | Robin Sacher  | Implementierung Shop                                 | 45'              |
| 8.2.K | 26.04.2024 | Robin Sacher  | Heal im Shop Shop                                    | 45'              |
| 8.3.L | 26.04.2024 | Robin Sacher  | Equipment im Shop                                    | 45'              |
| 9.1.M | 26.04.2024 |               |                                                      |               |
| 10.1.N | 26.04.2024 |Julian Hitz   | Gift Ability                                         | 45'              |
| 10.2.O | 26.04.2024 |Julian Hitz   | Gift Ability                                         | 45'              |
| 14.1.P | 26.04.2024 |Elias Spycher | Sound Design 1                                       | 45'              |
| 14.1.Q | 26.04.2024 |Elias Spycher | Sound Design 2                                       | 45'              |
Total:



## 3 Entscheiden

Game Loop ist sehr komplex, aus diesem Grund wurde kein richtiger Death Screen implemntiert, trotz langem probieren, sondern ein imidiate shutdown implementiert, also wenn man stirbt, dann wird die konsole beendet.
Wir haben uns ausserdem dazu entschieden, in dem Shop nur Rüstungsteile zu Verkaufen, da es sonst viel zu stark wäre, wenn man jedes Item im Shop aufsammeln könnte.

## 4 Realisieren

| AP-№  | Datum      | Zuständig     | geplante Zeit | tatsächliche Zeit |
| ----- | ---------- | ------------- | ------------- | ----------------- |
| 1.1.A | 15.03.2024 | Elias Spycher | 90'           | 30'               |
| 2.1.B | 15.03.2024 | Elias Spycher | 45'           | 10'               |
| 3.1.C | 16.03.2024 | Robin Sacher  | 10'           | 5'                |
| 4.1.D | 16.03.2024 | Robin Sacher  | 30'           | 30'               |
| 5.1.E | 22.03.2024 | Elias Spycher | 45'           | 45'               |
| 6.1.F | 22.03.2024 | Elias Spycher | 45'           | 45'               |
| 7.1.G | 16.03.2024 | Robin Sacher  | 45'           | 60'               |
| 7.2.H | 16.03.2024 | Robin Sacher  | 45            | 30'               |
| 8.1.I | 22.03.2024 | Robin Sacher  | 45            | 180'               |
| 8.2.J | 29.03.2024 | Robin Sacher  | 45            | 90'               |
| 8.3.L | 29.03.2024 | Robin Sacher  | 45            | 20'               |
| 9.1.M |            |                |               |                  |
| 10.1.N | 16.03.2024 | Julian Hitz  | 45            | 30'               |
| 10.2.O | 16.03.2024 | Julian Hitz  | 45            | 30'               |
| 14.1.P | 16.03.2024 | Elias Spycher  | 45            | 30'               |
| 14.2.Q | 16.03.2024 | Elias Spycher  | 45            | 30'               |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№   | Datum      | Resultat | Tester        |
| ------ | ---------- | -------- | ------------- |
| 1.1  | 26.04.2023 | OK       | Elias Spycher |
| 2.1  | 26.04.2023 | OK       | Elias Spycher |
| 2.2  | 26.04.2023 | OK       | Elias Spycher |
| 2.3  | 26.04.2023 | OK       | Elias Spycher |
| 2.4  | 26.04.2023 | OK       | Elias Spycher |
| 3.1  | 26.04.2023 | OK       | Elias Spycher |
| 4.1  | 26.04.2023 | OK       | Elias Spycher |
| 5.1  | 26.04.2023 | NOK       | Elias Spycher |
| 6.1  | 26.04.2023 | OK       | Elias Spycher |
| 7.1.1  | 26.04.2023 | OK       | Elias Spycher |
| 7.2.1  | 26.04.2023 | OK       | Elias Spycher |
| 8.1.1  | 26.04.2023 | OK       | Elias Spycher |
| 8.2.1  | 26.04.2023 | OK       | Elias Spycher |
| 8.3.1  | 26.04.2023 | OK       | Elias Spycher |
| 9.1  | 26.04.2023 | NOK       | Elias Spycher |
| 10.1  | 26.04.2023 | NOK       | Elias Spycher |
| 11.1  | 26.04.2023 | NOK       | Elias Spycher |
| 12.1  | 26.04.2023 | NOK       | Elias Spycher |
| 13.1  | 26.04.2023 | NOK       | Elias Spycher |
| 14.1.1  | 26.04.2023 | OK       | Elias Spycher |
| 14.1.2  | 26.04.2023 | OK       | Elias Spycher |
| 14.1.3  | 26.04.2023 | OK       | Elias Spycher |
| 14.1.4  | 26.04.2023 | NOK       | Elias Spycher |

### Testbericht

Unser projekt beinhaltet viele unvollständige Features, die durch die komplexe Struktur des Codes nicht umgesetzt werden konnten

## 6 Auswerten
- Portfolioeintrag Robin Sacher: https://portfolio.bbbaden.ch/view/view.php?t=dba6b0722940dd1cfc9b
- Portfolioeintrag Elias Spycher:
- Portfolioeintrag Damian Müller:
