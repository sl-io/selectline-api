<img align="left" src="sllogo.png" style="margin-right:30px;">

# Consolen-Demo für die SelectLine API
Der hier veröffentlichte Code zeigt die Nutzung der **SelectLine API**. Die unten aufgeführten Funktionen werden aktuell von der DemoApp unterstützt. Die Url der "SelectLine API", welche von dieser Funktion  genutzt wird, ist ebenso vermerkt. Für alle Funktionen bietet die "SelectLine API" eine Hilfe. Siehe <http://demo.slmobile.de/demoApi/help>

#### API Informationen abrufen 
Von der API wird die Bezeichnung, die Versionsnummer und die Beschreibung abgerufen.
<http://demo.slmobile.de/demoApi/>

#### Login [GET]
Mit Benutzername und Passwort wird sich bei er "SelectLine API" angemeldet.
<http://demo.slmobile.de/demoApi/login>

#### Kundenliste abrufen [GET]
Es wird die Liste der Kunden abgerufen.
<http://demo.slmobile.de/demoApi/customers>

#### Kunde (10007) abrufen [GET]
Abrufen von Informationen des Kunden 10007.
<http://demo.slmobile.de/demoApi/customers?filter=Number EQ '10007'>

#### Kunde (10007) ändern [PUT]
Es wird die Telefonnummer geändert.
<http://demo.slmobile.de/demoApi/Customers/10007>

## Technische Grundlagen des Projektes
Das Projekt wurde mit C# als Consolenanwendung umgesetzt.

Die Anmeldedaten sind in der Klassen-Datei "Program.cs" hinterlegt. Hier kann man diese leicht umstellen auf eine Url einer selbst gehosteten "SelectLine API". Dazu muss das Attribut BaseAddress angepasst werden.