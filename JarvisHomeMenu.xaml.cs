using System;
using System.Windows.Threading;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JARVIS_1_0
{
    /// <summary>
    /// Interaktionslogik für JarvisHomeMenu.xaml
    /// </summary>
    public partial class JarvisHomeMenu : Window
    {
        public JarvisHomeMenu()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += (sender, e) =>
            {
                ClockText.Text = DateTime.Now.ToString("HH:mm:ss");
                DateText.Text = DateTime.Now.ToString("dd. MMMM yyyy");
            };

            timer.Start();

            // Uhr direkt beim Start aktualisieren
            ClockText.Text = DateTime.Now.ToString("HH:mm:ss");
            DateText.Text = DateTime.Now.ToString("dd. MMMM yyyy");
        }

        

        private void ChatButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
