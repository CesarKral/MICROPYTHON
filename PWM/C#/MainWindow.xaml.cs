using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LedOnOffPWM
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

        private void sldrOnOff_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = sldrOnOff.Value;
            try
            {
                var soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soc.Connect("192.168.12.5", 5656);
                soc.Send(new ASCIIEncoding().GetBytes(value.ToString()));
                soc.Close();
            }
            catch (Exception x)
            {

            }
            lblSlider.Content = value;
        }
    }
}
