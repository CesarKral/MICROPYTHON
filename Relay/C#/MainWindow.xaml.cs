using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Relay
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool led;
        private bool r1;
        private bool r2;
        private bool r3;
        private bool r4;
        private bool r5;
        private bool r6;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLed_Click(object sender, RoutedEventArgs e)
        {
            led = !led;

            if (led)
            {
                
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.SendTimeout = 1000;
                    soc.ReceiveTimeout = 1000;
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("12"));
                    soc.Close();
                    btnLed.Content = "LED on";
                }
                catch (Exception x)
                {
                    var xx = x.ToString();
                    xx = "";
                    Console.WriteLine(xx);
                }
            }
            else
            {
               
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.SendTimeout = 1000;
                    soc.ReceiveTimeout = 1000;
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("13"));
                    soc.Close();
                    btnLed.Content = "LED off";
                }
                catch (Exception x)
                {
                    var xx = x.ToString();
                    xx = "";
                    Console.WriteLine(xx);
                }
            }
        }

        private void btnR1_Click(object sender, RoutedEventArgs e)
        {
            r1 = !r1;
            if (r1)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("0"));
                    soc.Close();
                    btnR1.Content = "R1 on";
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("1"));
                    soc.Close();
                    btnR1.Content = "R1 off";
                }
                catch (Exception x)
                {

                }
            }

        }

        private void btnR2_Click(object sender, RoutedEventArgs e)
        {
            r2 = !r2;
            if (r2)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("2"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("3"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
        }

        private void btnR3_Click(object sender, RoutedEventArgs e)
        {
            r3 = !r3;
            if (r3)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("4"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("5"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
        }

        private void btnR4_Click(object sender, RoutedEventArgs e)
        {
            r4 = !r4;
            if (r4)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("6"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("7"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
        }

        private void btnR5_Click(object sender, RoutedEventArgs e)
        {
            r5 = !r5;
            if (r5)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("8"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("9"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
        }

        private void btnR6_Click(object sender, RoutedEventArgs e)
        {
            r6 = !r6;
            if (r6)
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("10"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
            else
            {
                try
                {
                    var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    soc.Connect("192.168.0.49", 5050);
                    soc.Send(new ASCIIEncoding().GetBytes("11"));
                    soc.Close();
                }
                catch (Exception x)
                {

                }
            }
        }
    }
}
