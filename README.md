# Vorbereitungen für das Seminar
## Software
Da wir im Sperlhof vermutlich nur eine begrenzte Internetbandbreite verfügbar haben, ist es vorteilhaft, einige Dinge vorab zu installieren.
## Raspberry
Es werden ODroiden zur Verfügung stehen. Wer das Seminar am eigenen Raspberry/Odroid/Intel NUC, ... mitmachen möchte, soll ihn gerne mitbringen.
Da nur wenige Teilnehmer auf die Umfrage die Installation gewählt haben, gehe ich davon aus, dass jene, die auf eigenen Geräten arbeiten Home Assistant in der aktuellen Verion installiert haben.
## Mini-PC
Die Installation auf einem Mini-PC unter Proxmox werden wir am Seminarbeginn kurz durchbesprechen.
## Hardware
### Kleinzeug (bitte mitbringen)
- Mikro-USB-Kabel und USB-C-Kabel guter Qualität für ESP32
- 2 Netzwerkkabel (PC und Raspi), um WLAN-Engpässe zu vermeiden
- 1 Dreifachsteckdose
- 1 USB-Steckernetzteil zur Versorgung des ESP32
- Optional Switches, Netzwerkkabel (auch lange)
- Optional Sensoren und Aktoren (WLAN, ZigBee, Bluetooth, ...), die in Home Assistant eingebunden werden sollen
- Elektronikwerkzeug kann auch nicht schaden


# Infrastruktur
Wir werden den praktischen Teil des Seminars mit einem frisch installierten HA beginnen.
## Verteilung von Informationen
Benötigte Dateien werden über GitHub (https://github.com/htl-leo/sperlhof) bereitgestellt.

## Netzwerke
### WLAN Sperlhof
SSID: ????, Kennwort: ???

### Iot-LAN
SSID: **iot**, Kennwort **smarthome**
HA-User für alle: **leo** mit Kennwort **passme**

#### IP-Adressen und deren Nutzung:
- 192.168.2.1 &emsp; Ubiquity Unify DreamMachine
- 192.168.2.99 &emsp;Köcks Odroid mit zentralem MQTT-Broker (leo/passme)
- 192.168.2.201-215 &emsp;Odroiden mit homeassistant201 ...
- 192.168.2.151 ... &emsp;Homeassistant-Instanzen auf Proxmox
- 192.168.2.x ... &emsp;eigene Homeassistant-Instanzen der Seminarteilnehmer
- 192.168.3.x ... &emsp;Netzwerkgeräte (PCs, Handies, ESPs, ...)


# Sonstiges
Der Sperlhof hat einen Wellnessbereich. Badekleidung nicht vergessen!
Weitere Fragen zum Seminar bitte an gerald.koeck@aon.at senden.

Ich wünsche uns spannende drei Tage
Gerald


