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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Grading_App.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var Rand = new Random();
            Students = new List<Tuple<string, int>> { new Tuple<string, int>("Allan Smith", Rand.Next(0,100)),
            new Tuple<string, int>("Denise Orozco", Rand.Next(0,100)),
            new Tuple<string, int>("Drew Seward", Rand.Next(0,100)),
            new Tuple<string, int>("Ishjot Walia", Rand.Next(0,100)),
            new Tuple<string, int>("Jim Gilmartin", Rand.Next(0,100)),
            new Tuple<string, int>("Juan J. Ramirez", Rand.Next(0,100)),
            new Tuple<string, int>("Kelli Kearns", Rand.Next(0,100)),
            new Tuple<string, int>("Lucas Rowley", Rand.Next(0,100)),
            new Tuple<string, int>("Nolan Blew", Rand.Next(0,100)),
            new Tuple<string, int>("Riley Herman", Rand.Next(0,100)),
            new Tuple<string, int>("Sam Close", Rand.Next(0,100)),
            new Tuple<string, int>("Shayon Javadizadeh", Rand.Next(0,100)),
            new Tuple<string, int>("Terrence Cole", Rand.Next(0,100)),
            new Tuple<string, int>("Tim Weyel", Rand.Next(0,100)),
            new Tuple<string, int>("Zac Stringham", Rand.Next(0,100)),
            new Tuple<string, int>("Crystal Ophaso", Rand.Next(0,100)),
            new Tuple<string, int>("Matthre Glodack", Rand.Next(0,100)),
            new Tuple<string, int>("Tracy Mcalphin", Rand.Next(0,100)) };

        }

        public List<Tuple<string, int>> Students { get; }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
