import threading, socket
from Tkinter import *

class MyFirstGUI:
    def __init__(self, master):
        self.master = master
        master.title("Led ON/OFF")

        self.btnON = Button(master, text="ON", bg="pink", command=self.threadON)
        self.btnON.place(height=40, width=120, x=10, y=120)

        self.btnOFF = Button(master, text="OFF", bg="purple", command=self.threadOFF)
        self.btnOFF.place(height=40, width=120, x=10, y=200)

    def ON(self):
        host = '192.168.12.5'
        port = 5656
        connected = False
        s = socket.socket()
        while not connected:
            try:
                s.connect((host, port))
                connected = True
            except Exception as e:
                pass

        s.send("1")
        s.close()

    def threadON(self):
        self.thread = threading.Thread(target=self.ON)
        self.thread.start()

    def OFF(self):
        host = '192.168.12.5'
        port = 5656
        connected = False
        s = socket.socket()
        while not connected:
            try:
                s.connect((host, port))
                connected = True
            except Exception as e:
                pass

        s.send("0")
        s.close()

    def threadOFF(self):
        self.thread = threading.Thread(target=self.OFF)
        self.thread.start()


root = Tk()
root.resizable(0, 0)
root.geometry("400x500+20+20")
my_gui = MyFirstGUI(root)
root.mainloop()