# Vorbereitungen für das Seminar
## Software
Da wir im Sperlhof vermutlich nur eine begrenzte Internetbandbreite verfügbar haben, ist es vorteilhaft, einige Dinge vorab zu installieren.
### Docker
- Installation von Docker und Docker-Compose
- Inhalt der Zip-Datei docker/allinone.zip (GitHub) in beliebiges Verzeichnis entpacken und per docker-compose ausführen
## Hardware
### Kleinzeug
- Mikro-USB-Kabel guter Qualität für ESP32
- 2 Netzwerkkabel (PC und Raspi), um WLAN-Engpässe zu vermeiden
- 1 Dreifachsteckdose
- 1 USB-Steckernetzteil zur Versorgung des ESP32 
## Raspberry
Es werden einige ODroiden zur Verfügung stehen. Wer das Seminar am eigenen Raspberry/Odroid/Intel NUC, ... mitmachen möchte, soll ihn gerne mitbringen.
Das HomeAssistant-Image für den Raspberry findet ihr unter
- Raspi3: https://github.com/home-assistant/operating-system/releases/download/9.5/haos_rpi3-64-9.5.img.xz
- Raspi4: https://github.com/home-assistant/operating-system/releases/download/9.5/haos_rpi4-64-9.5.img.xz 

Wir werden den praktischen Teil des Seminars mit einem frisch installierten HA auf dem Raspi (https://www.home-assistant.io/installation/raspberrypi/) beginnen.

Fragen zum Seminar bitte an gerald.koeck@aon.at senden.

# Infrastruktur
## Netzwerke
### WLAN Sperlhof
SSID: ????, Kennwort: ???

### Iot-LAN
SSID: **iot**, Kennwort **smarthome**
HA-User für alle: **leo** mit Kennwort **passme**

#### IP-Adressen und deren Nutzung:
- 192.168.2.1 &emsp;Samba-Share mit leo/passme
- 192.168.2.3 &emsp;Köcks Raspi mit zentralem MQTT-Broker (leo/passme)
- 192.168.2.101-120 &emsp;Odroiden mit homeassistant-101 ...
- 192.168.2.121 ... &emsp;Homeassistant-Instanzen auf Proxmox





