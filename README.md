# home-codeingStandardsRefactoring-aschnee

# AUSARBEITUNG REFACTORING
## Was ist Refactoring?
Refactoring ist der strukturierte Vorgang des Optimierens und Ausbessern von Code, um diesen einfacher zu gestalten und dabei die Funktionen beizubehalten. 

## Die Vorteile/Nachteile von Refactoring
### Vorteile: 
- Besser lesbar für Aussenstehende
- Die Erleichterung der Weiterentwicklung der Software.
- Bessere Testbarkeit
- Die Steigerung der Performance der Software.
- Übersichtlicher

### Nachteile:
- Die versehentliche Implementierung von ungewollten Änderungen oder Fehlern. Auch scheinbar kleine Änderungen können große Wirkungen entfalten. Unit-Tests können dieses Risiko senken.
- Der Aufwand könnte größer sein als ursprünglich erwartet bzw. eingeplant.
- Der Abstimmungsaufwand zwischen Entwicklern und/oder Softwarearchitekten könnte umfangreicher als erwartet sein.
- Der Kunde merkt nichts von dem Refactoring, da sich für ihn alles unverändert anfühlt und er keine neuen Features erhält.

## Was sind die Refactoring-Schritte?
1. Testcase definieren
2. Testen ob Programm zu diesem Stand funktioniert bzw. was alles funktioniert
3. Einen „Code Smell“ ausbessern
4. Testen ob das Programm noch alle zuvor bekannten Funktionen erfüllt
5. Commit
6. alles wiederholen bis alle Smells ausgebessert sind
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
Schlecht strukturierter Quellcode

Code-Smell bezeichnet funktionierenden, aber schlecht struktuierten Quellcode. Der Begriff geht auf das Buch „Refactoring – Improving the Design of Existing Code“ von Martin Fowler und eine in diesem Buch verwendete Metapher von Kent Beck, dem Erfinder des Extreme Programmings, zurück. „If it stinks, change it“

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

# Santa Run

### Project description: 
This is a simple 2D side-scroll game. The Santa runs from left to right and has to avoid some obstacles by jumping over them.
The game ends when the Santa hits an obstacle.  The goal is to avoid as many obstacles as possible.

### Development platform: 
Windows 10, Unity version 2019.1.14f1, Visual Studio Community 2017, Scripting Runtime Version: .NET 4.0

### Target platform: 
WebGl and Standalone, RefRes: 1920 * 1080


### Visuals: 
<div>
<img src = "./Screenshots/sketch-SantaRun.JPG" width = "500">
</div>

[![SANTA RUN](https://i9.ytimg.com/vi/2C74XxBkFfI/mq1.jpg?sqp=CNWnze8F&rs=AOn4CLBrmO-tJ3gQ2BNeMxvrmQcsIhhcgQ)](https://www.youtube.com/embed/2C74XxBkFfI "Santa RUN")

https://www.youtube.com/embed/2C74XxBkFfI

### Necessary setup/execution steps: 
For playing the game go to: 
* WebGL: https://hs-teaching.github.io/WegGL-SantaRun/
* Standalone (.exe): Clone project and publish as Standalone

For development: Clone this project. 

### Third party material: 
* This game is based on the game Santa Run developed by Raja Biswas in the Udemy-course Unity 2018 Game Developmen by Example 
[Unity 2018 Game Development by Example](https://www.udemy.com/course/unity-2d-game-development-by-example/).
* Sprites are used from https://www.gameart2d.com/santa-claus-free-sprites.html


### Project state: 
Program is working correctly, no errors, refactoring is needed.
Refactoring needed: 
* del not used namespaces
* del unused variables
* del needless debugs
* del needless comments
* del unused methods
* rename variables (coding standards)
* rename methods (coding standards)
* fix poor conditional clauses
* fix poor formating
* replace magic string
* replace magic number

### Limitations: 
Only one level is implemented. 

### Lessons Learned: 
* Create 2D Scenes
* Use Quads for moving Backgrounds (Textures instead of Sprites)
* Use Particle System for snowing effect.
* Use Scene Management for switching between Scenes
* Create and control Animations (Animation, Animator and Scripts)
* Use the singelton pattern
* Spawn objects
* Use UI elements and manipulate UI elements with scrips


Copyright by smeerws
