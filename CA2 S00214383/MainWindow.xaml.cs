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
using System.Globalization;
using System.Collections.ObjectModel;

namespace CA2_S00214383
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        // List<Activity> atividades;
        ObservableCollection<Activity> atividades;
        ObservableCollection<Activity> filteredActivities = new ObservableCollection<Activity>();
        ObservableCollection<Activity> selectedActivities = new ObservableCollection<Activity>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create activities objects and properties
            Activity trecking = new Activity() { Name = "Trekking", ActivityDate = new DateTime(2021, 6, 01), Cost = 40.90m, TypeOfActivity = ActivityType.Land, Description = "Amazing Trekking with a breathtaking view"};
            Activity Kayaking = new Activity() { Name = "Kayaking", ActivityDate = new DateTime(2021, 6, 01), Cost = 69.90m, TypeOfActivity = ActivityType.Water, Description = "Get to discover the calm sea water in Sligo" };
            Activity Parachuting = new Activity() { Name = "Parachuting", ActivityDate = new DateTime(2021, 6, 01), Cost = 149.90m, TypeOfActivity = ActivityType.Air, Description="An unforgettable adventure" };
            Activity MountainBike = new Activity() { Name = "Mountain Bike", ActivityDate = new DateTime(2021, 6, 02), Cost = 99.90m, TypeOfActivity = ActivityType.Land, Description = "All materials included"};
            Activity Surfing = new Activity() { Name = "Surfing", ActivityDate = new DateTime(2021, 6, 02), Cost = 59.90m, TypeOfActivity = ActivityType.Water, Description="Best waves in March" };
            Activity HangGliding = new Activity() { Name = "Hang Gliding", ActivityDate = new DateTime(2021, 6, 02), Cost = 149.90m, TypeOfActivity = ActivityType.Land, Description="No experience needed" };
            Activity Abseling = new Activity() { Name = "Abseling", ActivityDate = new DateTime(2021, 6, 03), Cost = 79.90m, TypeOfActivity = ActivityType.Air , Description = "1 hour or 30 min of adventure"};
            Activity Sailing = new Activity() { Name = "Sailing", ActivityDate = new DateTime(2021, 6, 03), Cost = 219.90m, TypeOfActivity = ActivityType.Water , Description = "Up to 4 people"};
            Activity Helicopter = new Activity() { Name = "Helicopter Tour", ActivityDate = new DateTime(2021, 6, 03), Cost = 199.90m, TypeOfActivity = ActivityType.Air, Description = "Discover the area from the sky" };

            //creating a collection
            atividades = new ObservableCollection<Activity>();

            // adding the objects to the collection, display on screen
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

        //this method checks the activity selected and add details
        private void listBoxActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            //determine what was selected
            Activity selectedActivity = listBoxActivities.SelectedItem as Activity;
           
            //null check

            if (selectedActivity != null)
            {
                //update display
                tblkActivitiesDetails.Text = selectedActivity.GetActivitiesDetails();
            }

           
            //take action - update display
        }

        //method to output total cost
        private void lbxActSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            Activity teste = lbxActSelected.SelectedItem as Activity;
        

            //null check
            if (teste != null)
            {                
               tbkTotalCost.Text = teste.GetTotalCost().ToString();
            }

           
            //take action - update display
        }



        private void btnAddActivity_Click(object sender, RoutedEventArgs e)
        {
            Activity selected = listBoxActivities.SelectedItem as Activity;

            //check not null
            if (selected != null)
            {
                //remove from one list
                atividades.Remove(selected);

                //add to the other
                lbxActSelected.Items.Add(selected);
            }

            //display item was not selected
            else
                MessageBox.Show("Please select an item");
        }

        //method to remove from second list and add to the first one
        private void btnRemoveActivity_Click(object sender, RoutedEventArgs e)
        {
            //see what is selected
            Activity selected2 = lbxActSelected.SelectedItem as Activity;

            //check not null
            if (selected2 != null)
            {
                //remove from one list
                lbxActSelected.Items.Remove(selected2);

                //add to the other (first list)
                atividades.Add(selected2);
            }
            //display item was not selected
            else
                MessageBox.Show("Please select an item");
        }

        //applying filter by TypeOfActivity property
        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            //reset the filter
            filteredActivities.Clear();

            //if all checked, display all
            if(rbAll.IsChecked == true)
            {
                listBoxActivities.ItemsSource = atividades;
            }

            //else if Land is selected display Land
            if (rbLand.IsChecked == true)
            {
                foreach (Activity atividade in atividades)
                {
                    if (atividade.TypeOfActivity == ActivityType.Land)
                    {
                        filteredActivities.Add(atividade);
                    }
                }

                listBoxActivities.ItemsSource = filteredActivities;
            }

            //else if Water is selected display Water
            if (rbWater.IsChecked == true)
            {
                foreach (Activity atividade in atividades)
                {
                    if (atividade.TypeOfActivity == ActivityType.Water)
                    {
                        filteredActivities.Add(atividade);
                    }
                }

                listBoxActivities.ItemsSource = filteredActivities;
            }

            //else if Air is selected display Air
            if (rbAir.IsChecked == true)
            {
                foreach (Activity atividade in atividades)
                {
                    if (atividade.TypeOfActivity == ActivityType.Air)
                    {
                        filteredActivities.Add(atividade);
                    }
                }

                listBoxActivities.ItemsSource = filteredActivities;
            }
        }

        
    }
    }
