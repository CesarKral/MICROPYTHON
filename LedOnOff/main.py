#pip install esptool
#esptool.py --port COM4 erase_flash
#esptool.py --port COM4 --baud 115200 write_flash --flash_size=detect 0 esp8266-20170612-v1.9.1.bin
#pip install adafruit-ampy
#ampy --port COM4 put main.py
import network, socket
from machine import Pin

led = Pin(4, Pin.OUT)

sta_if = network.WLAN(network.STA_IF)
ap_if = network.WLAN(network.AP_IF)

ap_if.active(False)

if not sta_if.isconnected():
    sta_if.active(True)
    sta_if.connect("NameOfYourWifi","PasswordOfYourWifi")
    while not sta_if.isconnected():
        pass

print(sta_if.ifconfig())

def openSocket():
    ip = sta_if.ifconfig()[0]
    s = socket.socket()
    s.bind( (ip, 5656) )
    s.listen(1)

    while True:
        cliente, a = s.accept()
        data = cliente.recv(1)
        print(data[0])

        if (data[0] == 48):
            led.value(0)

        if (data[0] == 49):
            led.value(1)

        cliente.close()

openSocket()


