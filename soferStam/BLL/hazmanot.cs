using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class hazmanot
    {
        private int kodHazmana;
        public int KodHazmana
        {
            get { return kodHazmana; }
            set { kodHazmana = value; }
        }

        private DateTime dateHazmana;
        public DateTime DateHazmana
        {
            get { return dateHazmana; }
            set { dateHazmana = value; }
        }

        private int kodMazmin;
        public int KodMazmin
        {
            get { return kodMazmin; }
            set { kodMazmin = value; }
        }

        public hazmanot() { }

        public hazmanot(int hazmana, DateTime date, int mazmin)
        {
            this.kodHazmana = hazmana;
            this.dateHazmana = date;
            this.kodMazmin = mazmin;

        }

        public hazmanot(DataRow dr)
        {
            this.kodHazmana = Convert.ToInt32(dr["kodHazmana"]);
            this.dateHazmana = Convert.ToDateTime(dr["dateHazmana"]);
            this.kodMazmin = Convert.ToInt32(dr["kodMazmin"]);
        }

        public DataRow BuildRow()
        {
            DataTable dt = new hazmanotTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodHazmana"] = this.kodHazmana;
            dr["dateHazmana"] = this.dateHazmana;
            dr["kodMazmin"] = this.kodMazmin;
            return dr;
        }
    }
}
