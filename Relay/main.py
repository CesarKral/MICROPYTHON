import network, socket
from machine import Pin
pin1 = Pin(1, Pin.OUT)
pin2 = Pin(3, Pin.OUT)
pin3 = Pin(15, Pin.OUT)
pin4 = Pin(13, Pin.OUT)
pin5 = Pin(12, Pin.OUT)
pin6 = Pin(14, Pin.OUT)
pin7 = Pin(4, Pin.OUT)
sta_if = network.WLAN(network.STA_IF)
ap_if = network.WLAN(network.AP_IF)
ap_if.active(False)
if not sta_if.isconnected():
    sta_if.active(True)
    sta_if.connect("nameOfYourWifi","passwordOfYourWifi")
    while not sta_if.isconnected():
        pass
def openSocket():
    ip = sta_if.ifconfig()[0]
    s = socket.socket()
    s.bind( (ip, 5050) )
    s.listen(1)
    while True:
        client, a = s.accept()
        data = client.recv(6)
        print(data)
        if int(data) == 0:
            pin7.value(1)
        if int(data) == 1:
            pin7.value(0)

        if int(data) == 2:
            pin1.value(1)
        if int(data) == 3:
            pin1.value(0)

        if int(data) == 4:
            pin2.value(1)
        if int(data) == 5:
            pin2.value(0)

        if int(data) == 6:
            pin3.value(1)
        if int(data) == 7:
            pin3.value(0)

        if int(data) == 8:
            pin4.value(1)
        if int(data) == 9:
            pin4.value(0)

        if int(data) == 10:
            pin5.value(1)
        if int(data) == 11:
            pin5.value(0)

        if int(data) == 12:
            pin6.value(1)
        if int(data) == 13:
            pin6.value(0)

        client.close()
openSocket()


