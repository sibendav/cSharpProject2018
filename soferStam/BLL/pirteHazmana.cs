using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class pirteHazmana
    {
        private int kodPirteyHazmana;
        public int KodPirteyHazmana
        {
            get { return kodPirteyHazmana; }
            set { kodPirteyHazmana = value; }
        }

        private int kodHazmana;
        public int KodHazmana
        {
            get { return kodHazmana; }
            set { kodHazmana = value; }
        }

        
        private int kodAboda;
        public int KodAboda
        {
            get { return kodAboda; }
            set { kodAboda = value; }
        }

        private DateTime destinationDate;
        public DateTime DestinationDate
        {
            get { return destinationDate; }
            set
            {
                if (value > DateTime.Today)
                    destinationDate = value;
                else
                    throw new Exception("הקש תאריך גדול מהיום");
            }
        }

        private int amount;
        public int Amount
        {
            get { return amount; }
            set {
                if (value <= 0)
                    throw new Exception("הקש כמות חיובית");
                else
                    amount = value;
                }
        }
      

        private int kodSogKlaf;
        public int KodSogKlaf
        {
            get { return kodSogKlaf; }
            set { kodSogKlaf = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new Exception("הקש מחיר גדול מאפס");
                else
                    price = value;
            }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public pirteHazmana() { }

        public pirteHazmana(int pirty, int hazmana, int aboda, DateTime date, int amount, int klaf, int price, bool made)
        {
            this.kodPirteyHazmana = pirty;
            this.kodHazmana = hazmana;
           // this.kodPirteyHazmana = pirty;
            this.kodAboda = aboda;
            this.destinationDate = date;
            this.amount = amount;
            this.kodSogKlaf = klaf;
            this.price = price;
            this.status = made;
        }

        public pirteHazmana(DataRow dr)
        {
            this.kodPirteyHazmana = Convert.ToInt32(dr["kodPirteyHazmana"]);
            this.kodHazmana = Convert.ToInt32(dr["kodHazmana"]);
            //this.kodPirteyHazmana = Convert.ToInt32(dr["kodPirteyHazmana"]);
            this.kodAboda = Convert.ToInt32(dr["kodAboda"]);
            this.destinationDate = Convert.ToDateTime(dr["destinationDate"]);
            this.amount = Convert.ToInt32(dr["amount"]);
            this.kodSogKlaf = Convert.ToInt32(dr["kodSogKlaf"]);
            this.price = Convert.ToInt32(dr["price"]);
            this.status = Convert.ToBoolean(dr["status"]); 


        }

        public DataRow BuildRow()
        {
            DataTable dt = new pirteHazmanaTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodPirteyHazmana"] = this.kodPirteyHazmana;
            dr["kodHazmana"] = this.kodHazmana;
            //dr["kodPirteyHazmana"] = this.kodPirteyHazmana;
            dr["kodAboda"] = this.kodAboda;
            dr["destinationDate"] = this.destinationDate;
            dr["amount"] = this.amount;
            dr["kodSogKlaf"] = this.kodSogKlaf;
            dr["price"] = this.price;
            dr["status"] = this.status;
            return dr;
        }

    }
}
