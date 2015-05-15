using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Firefly
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class _Update : Window
    {
        public _Update()
        {
            InitializeComponent();
        }
/*
        public static string setupname { get; set; }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            int percent = int.Parse(Math.Truncate(percentage).ToString());
            Rectangle_Progress_Bar.Value = percent;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Show();
            Uri uri = new System.Uri(Ashor.data.Configuration.FileUpdateURL);
            UpdateWindow.setupname = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(uri, setupname);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            launchsetup();
        }

        private void launchsetup()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(setupname);
            process.Start();
            ExitSetup();
        }

        private void ExitSetup()
        {
            this.Hide();
            Environment.Exit(0);
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            HwndSource source = PresentationSource.FromVisual(this) as HwndSource;
            source.AddHook(WndProc);
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == NativeMethod.WM_SHOWME)
            {
                BringWindowBackToFront();
            }
            return IntPtr.Zero;
        }

        private void BringWindowBackToFront()
        {
            if (WindowState == WindowState.Minimized)
            {
                WindowState = WindowState.Normal;
            }
            //Get our current "TopMost" value.
            bool blnTop = Topmost;

            //Make our form jump to the top of everything.
            Topmost = true;

            //Set it back to whatever it was.
            Topmost = blnTop;
        }

        private void Square_Button_Minimize_MouseEnter(object sender, MouseEventArgs e)
        {
            Stroke_Button_Minimize.Background = Brushes.White;
            Stroke_Button_Minimize.BorderBrush = Brushes.White;
        }

        private void Square_Button_Minimize_MouseLeave(object sender, MouseEventArgs e)
        {
            Stroke_Button_Minimize.Background = new SolidColorBrush(Color.FromRgb(40, 40, 40));
            Stroke_Button_Minimize.BorderBrush = new SolidColorBrush(Color.FromRgb(40, 40, 40));
        }

        private void CancelCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
       */
    }
}
