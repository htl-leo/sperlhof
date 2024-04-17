# Projekt-Proxmox

Team:

* Birgit Schröder
* Thomas Wollersberger
* Gerhard Gehrer

## Vorbereitung

ISO-Download (Version: Proxmox VE 8.1 ISO Installer) von der Seite

[https://www.proxmox.com/de/downloads/proxmox-virtual-environment/iso](https://www.proxmox.com/de/downloads/proxmox-virtual-environment/iso)

### USB-Stick bootable machen

Download von 'ETCHER FOR WINDOWS (X86|X64) (PORTABLE)' und mit diesem Programm den USB-Stick bootable machen.

Die BOOT-Reichenfoge am Ziel-PC im Setup festlegen (USB).

### Boot vom USB-Stick

Kurz nach dem Einschaten des Rechners das Boot-Menü starten und den USB-Stick auswählen. Danach startet die Installation von Proxmox.

Das Installationsprogramm bietet unterschiedliche Optionen an.  Die die Option '...graphical' auswählen.

Auswahl der Länderspezifischen Optionen.

Als Passwort ist 'passme' gesetzt worden.

Ansonsten wird die Installation wie in dem Foliensatz fortgesetzt.

### Probleme

**USB-Stick** darf kein GPT-Format sein, sondern ein MBR. Falls dies nicht der Fall ist, gibt es eine Lösung.

Diskpart (Programm von Windows)

Befehl: listdisk .... richtige Nummer herausfinden

1. select disk nummer
2. clean
3. convert mbr
4. format fat32
5. select part 1
6. active

Achtung bei der Aufbereitung vom USB-Stick. Hierbei muss beachtet werden, dass der USB-Stick im FAT32 Format formatiert ist.

**CPU** ... es muss darauf geachtet werden, dass die CPU Parameter richtig eingestellt sind. Sonst wird bei der Verbindung der Fehler 'Failed to connect with the server' angezeigt.
