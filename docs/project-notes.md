Bereich Virtual Engineering Genauere Geräte Definitonen

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

* Hacking Simulator / Cybersecurity Informations/
  
  * idk how

* Machine Operator 
  
  * VR, operates machines
  * helping videos
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
    
    > > > > > > > Stashed changes:docs/project-info.md

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

Mit VR durchs Haus gehen und SmartHome Experience erleben; SmartHome Geräte nach belieben einrichten

### Geräte

**Klingel mit Kamera, Lampen, Klima/Heizung,** Schalosien, Mediaplayer/Fernseher/Lautsprecher, Türschloss, **Kamera,** Putzroboter, Gartenroboter, Energiehaushalt, Boiler, Steckdosen

#### Sensoren:

Temperatur, Regen/Wetter, Magnetsensor, Kontaktsensor, Bewegungsmelder, Helligkeit

#### Smart-Geräte

* Lampen
  
  * Properties:
    * Farbe, Helligkeit, Power, Zuletzt verwendete Farben
  - Aktionen: TurnOn, TurnOff, Toggle, SetColor, SetBrightness
  - Formen
    - LED Strip, Deckenleuchte, Stehlampe, Tischlampe

* Heizung/Klima
  
  * Properties:
    
    * Isttemp, Solltemp, Power, Modus(Heizen, Kühlen, Auto, Off), Lüfterstufe
  - Aktionen: SetTarget, SetMode, SetFanSpeed
  - Formen: Split, Radiatoren, Wärmewellenheizungen, Wärmepumpe
- Kamera
  
  - Properties:
    
    - Videofeed, letztes Ereignis
  
  - Ereignisse: Motion, Person, Objekt, Auto
  
  - Aktionen: Record(min in die Vergangenheit, min in die Zukunft)
  
  - Formen: 
    
    - Klingel mit Kamera, Dome, Turret
* Schalosien/Rollo
  
  * Properties:
    
    - % geöffnet/geschlossen, Zustand(Fährt hoch ,fährt runter,  gestoppt)
  - Aktionen: Open, Close, Stop, SetPosition
  - Formen:  
    
    * Außen, Innen
- Roboter:
  
  - Properties:
    - Location, Akku, Wasserstand, Tankstand, ET remaining, Zustand (Docked, Cleaning, Returning, Error)
  - Aktionen: StartCleaning, Pause, Return
  - Formen: Mähroboter, Saugroboter
- Haustür:
  - Properties: Offen, Unlocked, Locked
  - Aktionen: Open, Unlock, Lock

- Mediaplayer:
  
  - Properties
    - Welche Inhalte kann er wiedergeben(Audio, Audio+Video), Titel, Künstler, Mediastatus, Lautstärke, Mute, Power, Vorschau
    - Aktionen: Next, Previous, Play, Pause, SetVolume, Mute, TurnOn/Off
  - Formen
    - Fernseher, Lautsprecher

- Boiler
  
  - Properties: Power, Wasserstand, Isttemp, Solltemp
  - Aktionen, TurnOn, TurnOff, SetTarget

- Bewegungsmelder:
  
  - Events: Bewegung
  
  - Properties: letzte Bewegung
- Kontaktsensor:
  - Properties: Zustand, Abstand
  - Events: Opened, Closed

- Wandschalter
  
  - Formen: Schalter, Button
  
  - Events: gedrückt
- Umgebung: 
  - Properties: Wetter(Temp, Zustand), Zeit, 

- Tablet
