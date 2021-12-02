using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CA2_S00214383
{
    class Activity : IComparable
    {
        public string Name { get; set; }

        public DateTime dateTime { get; set; }

        public decimal Cost { get; set; }

        private string Description;

        public string MyProperty
        {
            get { return Description + Cost; }
            set { Description = value; }
        }


        //enum to get activity type
        public enum ActivityType { Air, Water, Land }

        public class TypeOfActivity
        {
            private TypeOfActivity activity;

            public void SetActivity(TypeOfActivity value)
            {
                activity = value;
            }

            public TypeOfActivity GetActivity()
            {
                return activity;
            }
        }

        public int CompareTo(object obj)
        {

            if (obj == null) return 1;

            Activity activitySelected = obj as Activity;
            if (activitySelected == null)

                return this.dateTime.CompareTo(activitySelected.dateTime);
            else
                throw new NotImplementedException();
        }

    
        
    }
}
