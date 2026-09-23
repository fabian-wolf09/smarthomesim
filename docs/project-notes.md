Bereich Virtual Engineering 

3D + _Unity_ (Austauschbar) 

Team: Laurin Forster, Fabian, Beatriz, me

VR 

## Ideenbereiche

* VR
* AR
  * Overlay von wichtigen Informationen
  * Erkennung von Informationen

## Ideen

<<<<<<< Updated upstream:docs/project-notes.md
*   Interaktive Lernvideos / Lernbereiche
*   <span style="color:hsl(60,75%,60%);">Flugzeugssimulator / Fahrzeugsimulator (z.B für Führerschein \[VR\] )</span> 
    *   Autos
    *   Moped
    *   Busse
*   AR/VR Product Customization (z.B Auto)
*   <span style="color:hsl(60,75%,60%);">“Wood Workshop” aber Elektronik</span>
*   Produktionsstätte Sim
    *   Abläufe simuliert
*   <span style="color:hsl(60,75%,60%);">Smart Home Sim</span>
    *   Haus einrichten mit smarthome devices
    *   Sandbox
*   Weltraum/Raketen Sim
*   Cafe Sim (Niederlande)
*   Hacking Simulator / Cybersecurity Informations/
    *   idk how
*   Machine Operator 
    *   VR, operates machines
    *   helping videos
=======
* Interaktive Lernvideos / Lernbereiche
* <span style="color:hsl(60,75%,60%);">Flugzeugssimulator / Fahrzeugsimulator (z.B für Führerschein \[VR\] )</span> 
  * Autos
  * Moped
  * Busse
* AR/VR Product Customization (z.B Auto)
* <span style="color:hsl(60,75%,60%);">“Wood Workshop” aber Elektronik</span>
* Produktionsstätte Sim
  * Abläufe simuliert
* <span style="color:hsl(60,75%,60%);">Smart Home Sim</span>
  * Haus einrichten mit smarthome devices
  * Sandbox
* Weltraum/Raketen Sim
* Cafe Sim (Niederlande)
* Whore Simulator VR
  * you are a Towns whore and need to reach a people goal
* Hacking Simulator / Cybersecurity Informations/
  * idk how
* Machine Operator 
  * VR, operates machines
  * helping videos
>>>>>>> Stashed changes:docs/project-info.md

Rahmenbedingungen: 

* Jahresprojekt in Gruppen (2-3 Personen)
* Technischer Anspruch
  * z.b Abbildung Anlage
  * z.b Abbildung Prozess
* Sinnhaftigkeit (Nutzen)
* Umsetzung mit Unity
* Arbeiten mit Versionskontrollsystem (GIT)
* Zusammenarbeit mit anderen Abteilungen möglich / erwünscht

> ## SmartHome Sim - our theme

Abteile: 

* VR Implementation - Laurin
* 3d Modelle (Haus + Geräte mit Logik ohne configs (ohne API) - Beatriz
* Konfig von Geräten (Logik + UI von Handy/Tablet und Einstellungen) - Fabian
* Platzierung von Geräten (Logik + UI) - Manuel

Haus importieren; Mit VR durchs Haus gehen und SmartHome Experience erleben; SmartHome Geräte nach belieben einrichten





### Geräte

**Klingel mit Kamera, Lampen, Klima/Heizung,** Schalosien, Mediaplayer/Fernseher/Lautsprecher, Türschloss, **Kamera,** Putzroboter, Gartenroboter, Energiehaushalt, Boiler, Steckdosen

#### Sensoren:

Temperatur, Regen/Wetter, Magnetsensor, Kontaktsensor, Bewegungsmelder, Helligkeit

#### Smart-Geräte

* Lampen
  
  * Properties:
    * Farbe, Helligkeit, Power, Verbrauch
  - Formen
    - LED Strip, Deckenleuchte, Stehlampe, Tischlampe

* Heizung/Klima
  
  * Properties:
    
    * Zieltemperatur, Solltemp, Isttemp, Power, Verbrauch, Kann(Heizen, Kühlen, beides)
  - Formen: Split, Radiatoren, Wärmewellenheizungen, Wärmepumpe
- Kamera
  
  - Properties:
    
    - Power, Videofeed
  - Ereignisse: Motion, Person, Objekt, Auto
  
  - Formen: 
    
    - Klingel mit Kamera, Dome, Turret
* Schalosien/Rollo
  
  * Properties:
    
    - 100 geöffnet/geschlossen
  - Formen:  
    * Außen, Innen
- Roboter:
  - Properties:
    - Location, Akku, Wasserstand, Tankstand
  - Formen: Mähroboter, Saugroboter
- Mediaplayer:
  - Properties
    - Welche Inhalte kann er wiedergeben, Titel, Künstler, Mediastatus
  - Formen
    - Fernseher, Lautsprecher

#### Steuergeräte

Wandschalter:

Tablet:
