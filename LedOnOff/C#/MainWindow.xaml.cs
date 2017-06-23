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

namespace LedOnOff
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnON_Click(object sender, RoutedEventArgs e)
        {
            new Thread(ON).Start();
        }

        private void btnOFF_Click(object sender, RoutedEventArgs e)
        {
            new Thread(OFF).Start();
        }

        private void ON()
        {
            try
            {
                var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soc.Connect("192.168.12.5", 5656);
                soc.Send(new ASCIIEncoding().GetBytes("1"));
                soc.Close();
            }
            catch (Exception x)
            {

            }
        }

        private void OFF()
        {
            try
            {
                var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soc.Connect("192.168.12.5", 5656);
                soc.Send(new ASCIIEncoding().GetBytes("0"));
                soc.Close();
            }
            catch (Exception x)
            {

            }
        }
    }
}
