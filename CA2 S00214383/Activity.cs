using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CA2_S00214383
{
    //enum to get activity type
    public enum ActivityType { Air, Water, Land }

    public class Activity : IComparable
    {
        public string Name { get; set; }


        
        public DateTime ActivityDate { get; set; }

        public decimal Cost { get; set; }

        //object to display activities details plus cost
        public string Description { get; set; }

        public ActivityType TypeOfActivity { get; set; }


        //method to output details and cost for each activity
        public string GetActivitiesDetails()
        {
            return $"{Name} - {Description} \nCost per person: {Cost:c}";
        }

        //method to calculate the total cost
        public decimal GetTotalCost()
        {

            decimal total = 0;
           
            total += Cost ;
            return total;
            //decimal sum = 0;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    sum += Convert.ToDecimal(listBox1.Items[i]);
            //}
            //label1.Text = "Sum all the Numbers : " + sum;
        }



        public int CompareTo(object obj)
        {

            if (obj == null) return 1;

            Activity activitySelected = obj as Activity;
            if (activitySelected == null)

                return this.ActivityDate.CompareTo(activitySelected.ActivityDate);
            else
                throw new NotImplementedException();
        }


        public override string ToString()
        {
            return $"{Name }, {ActivityDate.ToShortDateString()}";
        }


    }
}
