using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class hespekim
    {
        private int kodHespek;
        public int KodHespek
        {
            get { return kodHespek; }
            set { kodHespek = value; }
        }

        private int kodParitHazmana;
        public int KodParitHazmana
        {
            get { return kodParitHazmana; }
            set { kodParitHazmana = value; }
        }
       

        //private int kodAboda;
        //public int KodAboda
        //{
        //    get { return kodAboda; }
        //    set { kodAboda = value; }
        //}

        
        private DateTime theDate;
        public DateTime TheDate
        {
            get { return theDate; }
            set { theDate = value; }
        }

        private DateTime fromTime;
        public DateTime FromTime
        {
            get { return fromTime; }
            set
            {
                if (value < this.tillTime)
                    fromTime = value;
                else
                    throw new Exception("לא מלאת את השעות כראוי");
                     }
        }

        private DateTime tillTime;
        public DateTime TillTime
        {
            get { return tillTime; }
            set
            {
                if (value > this.fromTime)
                    tillTime = value;
                else 
                    throw new Exception("לא מלאת את השעות כראוי");
            }
        }

        
        public hespekim() { }

        public hespekim(int kHespek, int kHazmana, DateTime thedate, DateTime from, DateTime till)
        {
            this.kodHespek = kHespek;
            this.kodParitHazmana = kHazmana;
            //this.kodAboda = kAboda;
            this.theDate = thedate;
            this.fromTime = from;
            this.tillTime = till;
           

        }

        public hespekim(DataRow dr)
        {
            this.kodHespek = Convert.ToInt32(dr["kodHespek"]);
            this.kodParitHazmana = Convert.ToInt32(dr["kodParitHazmana"]);
            //this.kodAboda = Convert.ToInt32(dr["kodAboda"]);
            this.theDate = Convert.ToDateTime(dr["theDate"]);
            this.fromTime = Convert.ToDateTime(dr["fromTime"]);
            this.tillTime = Convert.ToDateTime(dr["tillTime"]);
          

        }

        public DataRow BuildRow()
        {
            DataTable dt = new hespekimTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodHespek"] = this.kodHespek;
            dr["kodParitHazmana"] = this.kodParitHazmana;
            //dr["kodAboda"] = this.kodAboda;
            dr["theDate"] = this.theDate;
            dr["fromTime"] = this.fromTime;
            dr["tillTime"] = this.tillTime;
            return dr;
        }


    }
}
