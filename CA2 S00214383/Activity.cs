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
        public string Description
        {
            get { return Description + Cost; }
            set { Description = value; }
        }

        public ActivityType TypeOfActivity { get; set; }


        //public class TypeOfActivity
        //{
        //    private TypeOfActivity activity;

        //    public void SetActivity(TypeOfActivity value)
        //    {
        //        activity = value;
        //    }

        //    public TypeOfActivity GetActivity()
        //    {
        //        return activity;
        //    }
        //}

        //method to output details and cost for each activity
        public string GetActivitiesDetails()
        {
            return $"Activity: {Name} \nCost per person: {Cost:c}";
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
