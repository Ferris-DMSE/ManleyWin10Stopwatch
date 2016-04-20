using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer timer;

        public MainPage()
        {
            this.InitializeComponent();
        }

        //private void txtboxDisplay_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}


        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            TimerClass.Start();
            StartTimer();
        }

        private void StartTimer()
        {
            if (timer != null)
            {
                timer.Start();
            }
            else
            {
               TimerSetup();
                timer.Start();
            }
        }

        private void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
            }
            
        }

        public void TimerSetup()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
        }

        private void Timer_Tick(object sender, object e)
        {
            txtboxDisplay.Text = TimerClass.UpdateTimeLabel();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            StopTimer();
            TimerClass.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            TimerClass.Pause();
        }
    }
}

