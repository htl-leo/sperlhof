# Vorbereitungen für das Seminar
## Software
Da wir im Sperlhof vermutlich nur eine begrenzte Internetbandbreite verfügbar haben, ist es vorteilhaft, einige Dinge vorab zu installieren.
## Raspberry
Es werden ODroiden zur Verfügung stehen. Wer das Seminar am eigenen Raspberry/Odroid/Intel NUC, ... mitmachen möchte, soll ihn gerne mitbringen.
Im Zuge des Überblicks über die Infrastruktur, den sich viele Teilnehmer gewünscht haben (https://fragab.de/5Ws1rp5g) werden wir auf einem NUC Homeassistant über Proxmox gemeinsam installieren und dann die wichtigsten AddOns und Integrationen in Betrieb nehmen.
## Hardware
### Kleinzeug (bitte mitbringen)
- Mehrere Mikro-USB-Kabel und USB-C-Kabel guter Qualität für ESP32
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
- 192.168.2.3 &emsp;Köcks Raspi mit zentralem MQTT-Broker (leo/passme)
- 192.168.2.201-215 &emsp;Odroiden mit homeassistant201 ...
- 192.168.2.232 &emsp;Proxmox auf Mini-PC
- 192.168.2.141 ... &emsp;Homeassistant-Instanzen auf Proxmox
- 192.168.2.x ... &emsp;eigene Homeassistant-Instanzen der Seminarteilnehmer
- 192.168.3.x ... &emsp;Netzwerkgeräte (PCs, Handies, ESPs, ...)

#### Seitens der Seminarleitung verfügbare Hardware für Miniprojekte am Mittwoch:
- Verschiedene Sensoren/Aktoren für Implementierungen unter ESPHome (Radarsensoren, Buzzer, OLED-Displays, Neopixel, Temperatur/Luftfeuchte, CO2, AirQuality, ... )
- Zigbee-Sensoren/Aktoren
- Shelly-Aktoren
- Kamera und Coral TPU-Stick
- Neue ESP32-Geräte zum Testen (C6, S3, ...)
- Ulanzi Desktop-Clock
Natürlich sind auch eigene Geräte gerne willkommen, um am Mittwoch damit zu expreimentieren.

# Sonstiges
Der Sperlhof hat einen Wellnessbereich. Badekleidung nicht vergessen!
Weitere Fragen zum Seminar bitte an gerald.koeck@aon.at senden.

Wir wünschen uns spannende drei Tage
Michael und Gerald
