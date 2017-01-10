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
        }

        private List<Tuple<string, int>> _students = new List<Tuple<string, int>>()
        {
            new Tuple<string, int>("Allan Smith", 70),
            new Tuple<string, int>("Denise Orozco", 70),
            new Tuple<string, int>("Drew Seward", 70),
            new Tuple<string, int>("Ishjot Walia", 70),
            new Tuple<string, int>("Jim Gilmartin", 70),
            new Tuple<string, int>("Juan J. Ramirez", 70),
            new Tuple<string, int>("Kelli Kearns", 70),
            new Tuple<string, int>("Lucas Rowley", 70),
            new Tuple<string, int>("Nolan Blew", 70),
            new Tuple<string, int>("Riley Herman", 70),
            new Tuple<string, int>("Sam Close", 70),
            new Tuple<string, int>("Shayon Javadizadeh", 70),
            new Tuple<string, int>("Terrence Cole", 70),
            new Tuple<string, int>("Tim Weyel", 70),
            new Tuple<string, int>("Zac Stringham", 70),
            new Tuple<string, int>("Crystal Ophaso", 70),
            new Tuple<string, int>("Matthre Glodack", 70),
            new Tuple<string, int>("Tracy Mcalphin", 70),
        };

        public List<Tuple<string, int>> Students
        {
            get { return _students; }
        }

    }
}
