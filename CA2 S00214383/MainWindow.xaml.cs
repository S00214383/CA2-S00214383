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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2_S00214383
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> atividades;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create activities
            Activity trecking = new Activity() { Name = "Trecking", dateTime = DateTime.Now };
            Activity Kayaking = new Activity() { Name = "Kayaking", dateTime = DateTime.Now };
            Activity Parachuting = new Activity() { Name = "Parachuting", dateTime = DateTime.Now };
            Activity MountainBike = new Activity() { Name = "Mountain Bike", dateTime = DateTime.Now };
            Activity Surfing = new Activity() { Name = "Surfing", dateTime = DateTime.Now };
            Activity HangGliding = new Activity() { Name = "Hang Gliding", dateTime = DateTime.Now };
            Activity Abseling = new Activity() { Name = "Abseling", dateTime = DateTime.Now };
            Activity Sailing = new Activity() { Name = "Sailing", dateTime = DateTime.Now };
            Activity Helicopter = new Activity() { Name = "Helicopter Tour", dateTime = DateTime.Now };


            //add to list
            atividades = new List<Activity>();

            // display on screen
            atividades.Add(trecking);
            atividades.Add(Kayaking);
            atividades.Add(Parachuting);
            atividades.Add(MountainBike);
            atividades.Add(Surfing);
            atividades.Add(HangGliding);
            atividades.Add(Abseling);
            atividades.Add(Sailing);
            atividades.Add(Helicopter);
            
            //naming object property to output
            listBoxActivities.ItemsSource = atividades;

        }
    }


    
   
}
