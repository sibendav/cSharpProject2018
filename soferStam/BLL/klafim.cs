using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class klafim
    {
        private int kodKlaf;
        public int KodKlaf
        {
            get { return kodKlaf; }
            set { kodKlaf = value; }
        }

        private string nameOfKlaf;
        public string NameOfKlaf
        {
            get { return nameOfKlaf; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם");
                else if (value[0] == ' ')
                    throw new Exception("לא מתחיל ברווח");
                else nameOfKlaf = value;
            }
        }

        private string sizeOfKlaf;
        public string SizeOfKlaf
        {
            get { return sizeOfKlaf; }
            set {
                if (Convert.ToDouble(value) < 0)
                    throw new Exception("הקש גודל חיובי");
                sizeOfKlaf = value;
            }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }




        public klafim() { this.status = true; }

        public klafim(int kod, string name, string size)
        {
            this.kodKlaf = kod;
            this.nameOfKlaf = name;
            this.sizeOfKlaf = size;
            this.status = true;
            //is.theAmountOfTimeToWriteEach = time.ToString();

        }

        public klafim(DataRow dr)
        {
            this.kodKlaf = Convert.ToInt32(dr["kodKlaf"]);
            this.nameOfKlaf = Convert.ToString(dr["nameOfKlaf"]);
            this.sizeOfKlaf = Convert.ToString(dr["sizeOfKlaf"]);
            this.status = Convert.ToBoolean(dr["status"]);
            //is.theAmountOfTimeToWriteEach = Convert.ToString(dr["theAmountOfTimeToWriteEach"]);
        }

        public DataRow BuildRow()
        {
            DataTable dt = new klafimTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodKlaf"] = this.kodKlaf;
            dr["nameOfKlaf"] = this.nameOfKlaf;
            dr["sizeOfKlaf"] = this.sizeOfKlaf;
            dr["status"] = this.status;
            return dr;
        }
    }
}
