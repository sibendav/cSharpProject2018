using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class sogKlaf
    {
        private int kodSogKlaf;
        public int KodSogKlaf
        {
            get { return kodSogKlaf; }
            set { kodSogKlaf = value; }
        }

        private string nameSogKlaf;
        public string NameSogKlaf
        {
            get { return nameSogKlaf; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם");
                else if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                else nameSogKlaf = value;
                 
            }
        }
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }



        public sogKlaf() { this.status = true; }

        public sogKlaf(int kod, string name)
        {
            this.kodSogKlaf = kod;
            this.nameSogKlaf = name;
            this.status = true;
           

        }

        public sogKlaf(DataRow dr)
        {
            this.kodSogKlaf = Convert.ToInt32(dr["kodSogKlaf"]);
            this.nameSogKlaf = Convert.ToString(dr["nameSogKlaf"]);
            this.status = Convert.ToBoolean(dr["status"]);
            
        }

        public DataRow BuildRow()
        {
            DataTable dt = new sogKlafTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodSogKlaf"] = this.kodSogKlaf;
            dr["nameSogKlaf"] = this.nameSogKlaf;
            dr["status"] = this.status;
          
            return dr;
        }
    }
}
