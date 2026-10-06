# Placement of new smart devices (UI & Logic)

this feature is accessible via the `hub icon` on the main screen

## GUI

is now in phone 
-> started via Market

has clickable icons for each and every diff smartdevice

upon selecting wanted device, starts active placement. <a href="When placing">see here for active placement</a>


## Backend

upon creating a new device (by placing it), adds it to global registry (so that it can be configured via smartphone/tablet) 

many smarthomedevices will also only have certain possible placements (e.g lamps only on the top wall, not clipping into the wall) -> solution is to make a trigger/collider that has to be checked

good tagging of objects in project (windows, doors and such)

## When placing

devices appear transparent when selecting placement position


## Controls ```[based on Meta Quest 3]```

### ```[When not active placing]```

Right controller: 
- Joystick: Selecting what device in the menu 
- R1
- R2 
- BR1
- BR2

Left controller: 
- Joystick: Movement
- L1 
- L2
- BL1
- BL2


### ```[When active placing]```

Right controller: 
- position: decides placement position 
- Joystick: Rotation of placing Obj
- R1
- R2 
- BR1
- BR2


Left controller: 
- Joystick: Movement
- L1 
- L2
- BL1
- BL2




## misc

- no creation of the smartdevice before the user confirms it 
