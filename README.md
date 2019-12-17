# home-codeingStandardsRefactoring-aschnee

# AUSARBEITUNG REFACTORING
## Was ist Refactoring?
Refactoring ist der strukturierte Vorgang des Optimierens und Ausbessern von Code, um diesen einfacher zu gestalten und dabei die Funktionen beizubehalten. 

## Die Vorteile/Nachteile von Refactoring
### Vorteile: 
- Besser lesbar für Aussenstehende
- Redundanz wird vermieden
- Bessere Testbarkeit
- Code leichter erweiterbar
- Übersichtlicher

### Nachteile:
- Neue unerwartete Fehler können auftreten
- Testaufwand
- Abstimmungsaufwand zwischen Programmierern

## Was sind die Refactoring-Schritte?
1. Testcase definieren
2. Testen ob Programm zu diesem Stand funktioniert bzw. was alles funktioniert
3. Einen „Code Smell“ ausbessern
4. Testen ob das Programm noch alle zuvor bekannten Funktionen erfüllt
5. Commit
6. Wiederhole Schritt 3, 4 ,5 bis alle Smells ausgebessert sind
7. Projekt pushen 

## Prinzipien von gutem Code:
DRY - Don’t Repeat Yourself 
Unnötige wiederholte/redundante Sachen können reduziert werden.
KISS - Keep it Simple, Stupid
Außenstehende sollten den Code auch verstehen können.
YAGNI  - You Ain’t Gonna Need
Code der nicht benutzt wird kann gelöscht werden.
Principle of least Astonishment
Der User soll nie überrascht werden und jegliche Benennungen sollen klar erkenntlich angegeben sein was diese erfüllen.
SoC - Separation of Concerns
Der Code soll zusammengehörige Funktionen in diverse Abschnitte gliedern.

## Was versteht man unter Code Smell?
Der Begriff beschreibt funktionalen Code, welcher jedoch keine gute Strukturierung aufweist und oft unnötig komplex ist. 

## 10 Code Smells Beispiele

### 1. Kommentare
Kommentare sollen den Code für Andere leichter verständlich machen. Dabei sollten man sie in einer angemessenen Menge einsetzen, weil ein Überschuss an Kommentaren wiederrum zu Unübersichtlichkeit führt. Die Formulierung der Kommentaren selbst sollte für Menschen verständlich sein.
```c#
// Calling function 
        Message(msg); 
```
### 2. Zu lange Methoden
Die Funktionen einer Methode sollen leicht verständlich, lesbar und ausbesserbar sein, daher sollte eine Methode nie mehr als zehn Zeilen umfassen. 
```c#
public void SetResult()
{
	float a = float.Parse(ip_varA.text);
	float b = float.Parse(ip_varB.text);
	result.text = AddNumbers(a, b).ToString();
	ip_varA.interactable = false;
	ip_varB.interactable = false;
	ip_varC.interactable = false;
	ip_varD.interactable = false;
	Btn_Add.interactable = false;
	Btn_Reset.interactable = true;
	Debug.Log (“Reset Btn pressed”)
}
```
### 3. Zu komplexe/verwirrende Namensgebung
Um Zeit und Verwirrung zu sparen sollten die vergebenen Namen immer Sinn ergeben und nach einem einheitlichen System ausgewählt sein. 
```c#
public void _RstTheRslt1(){}
public void retTheresult(){}
```
### 4. Zu lange Namensgebung
Um Zeit und Verwirrung zu sparen sollten die vergebenen Namen immer relativ kurz und aussagekräftig sein.
```c#
public string = thisVariableIsAStringAndIsItsNameIsMaybeABitTooLong;
```
### 5. Zu kurze Namensgebung
Auch zu kurze Namen können zu Unklarheit führen und sollten vermieden werden. 
```c#
public GameObject = gO;
```
### 6. Doppelter Code
Manche Schritte können einfach zusammengefasst werden, wodurch man an Zeit sparen kann und einen übersichtlicheren Code verfasst. 
```c#
protected void SetBlueBoxVisibility(bool blueBoxVisibility)
    {
        Project project = LoadProject();
        project.ShowBlueBox = blueBoxVisibility
        ReDrawSomeThings();
        ShowBlueBoxPanel(blueBoxVisibility);
        RaiseStatusUpdated();
    }

    protected void SetRedBoxVisibility(bool redBoxVisibility)
    {
        Project project = LoadProject();
        project.ShowRedBox = redBoxVisibility
        ReDrawSomeThings();
        ShowRedBoxPanel(redBoxVisibility);
        RaiseStatusUpdated();
    }
```
### 7. Unbenutzte NameSpaces
Unnötige NameSpaces sollten möglichst gelöscht werden, um Verwirrung und Probleme zu vermeiden. 
```c#
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
``` 
### 8. Unerreichbarer Code
Unbenutzer Code verschwendet Rechenzeit und Speicher.
```c#
public int Add(int x, int y)
{
    return x + y;
    return 2 + 2;
}
```
### 9. Unbenutzte Parameter
Wenn Parameter in der Methode angegeben werden, müssen sie darin auch Verwendung finden. 
```c#
public int Add(int x, int y, int z)
{
    return x + y;
}
```
### 10. Tiefe Verschachtelungen
Zu tiefe Verschachtelungen führen zu Verwirrung und Unverständlichkeit.
```c#
do 
{   
    statement(s);
    do 
    {  
        statement(s);
        do
	{
	    statement(s)
	}
	while(condition);
    }
    while(condition);
}
while(condition);
```
Copyright by Alina Schneeberger

# README
## Development Platform
- Windows 10 1909
- Unity Version: 2019.1.14f1
- Visual Studio Version: Visual Studio Community 2019 16.3.10
- Scripting Runtime Version: .NET 4.x Equivalent
- API Compatibility Level: .NET Standard 2.0

## Testcase
- Spiel starten
- über Hindernisse springen
- gegen ein Hinderniss laufen
- auf Restart klicken

## Game 
Copyright: smeerws