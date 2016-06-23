using PriCardioMobile.DataConnection;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PriCardioMobile
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            var customer = Requests.GetData();
            textBlockName.Text = customer.Result.Name;
            textBlockPulse.Text = customer.Result.Pulse.ToString();
            textBlockSYS.Text = customer.Result.SYS.ToString();
            textBlockDIA.Text = customer.Result.DIA.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationData.Current.LocalSettings.Values["id"] = null;
            this.Frame.Navigate(typeof(LoginPage));
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            InitData();
        }
    }
}
