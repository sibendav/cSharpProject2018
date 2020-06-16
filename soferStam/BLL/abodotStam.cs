using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using soferStam.BLL;

namespace soferStam.BLL
{
    class abodotStam
    {
        private int kodAboda;
        public int KodAboda
        {
            get { return kodAboda; }
            set { kodAboda = value; }
        }

        private string nameOfAboda;
        public string NameOfAboda
        {
            get { return nameOfAboda; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם");
                else if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                else nameOfAboda = value; 
            }
        }

        private int kodKlaf;
        public int KodKlaf
        {
            get { return kodKlaf; }
            set { kodKlaf = value; }
        }

        private int amountOfKlafim;
        public int AmountOfKlafim
        {
            get { return amountOfKlafim; }
            set
            {
                if (value <= 0)
                    throw new Exception("הקש מספר גדול מאפס");
                else
                    amountOfKlafim = value; 
            }
        }

        private string writingType;//לבדוק
        public string WritingType
        {
            get { return writingType; }
            set
            {
                if (value == "")
                    throw new Exception("חסר סוג כתיבה");
                else if (value[0] == ' ')
                    throw new Exception("לא מתחיל ברווח");
                else writingType = value; 
            }
        }

        private double theTimeToWrite;
        public double TheTimeToWrite
        {
            get { return theTimeToWrite; }
            set {
                if (Convert.ToDouble(value) <= 0)
                    throw new Exception("הקש כמות זמן חיובית");
                else
                    theTimeToWrite = value;
            }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public abodotStam()
        { this.status = true; }

        public abodotStam(int kodAboda, string nameAboda, int kodKlaf, int amount, string type, double time)
        {
            this.kodAboda = kodAboda;
            this.nameOfAboda = nameAboda;
            this.kodKlaf = kodKlaf;
            this.amountOfKlafim = amount;
            this.writingType = type;
            this.theTimeToWrite = time;
            this.status = true;
        }

        public DataRow BuildRow()
        {
            abodotStamTable allPro = new abodotStamTable();
            DataTable dtPro = allPro.Dt;
            DataRow dr = dtPro.NewRow();
            dr["kodAboda"] = this.kodAboda;
            dr["nameOfAboda"] = this.nameOfAboda;
            dr["kodKlaf"] = this.kodKlaf;
            dr["amountOfKlafim"] = this.amountOfKlafim;
            dr["writingType"] = this.writingType;
            dr["theTimeToWrite"] = this.theTimeToWrite;
            dr["status"] = this.status;
            return dr;
        }

        public abodotStam(DataRow drOfabodotStam)
        {
            this.kodAboda = Convert.ToInt32(drOfabodotStam["kodAboda"]);
            this.nameOfAboda = Convert.ToString(drOfabodotStam["nameOfAboda"]);
            this.kodKlaf = Convert.ToInt32(drOfabodotStam["kodKlaf"]);
            this.amountOfKlafim = Convert.ToInt32(drOfabodotStam["amountOfKlafim"]);
            this.writingType = Convert.ToString(drOfabodotStam["writingType"]);
            this.theTimeToWrite = Convert.ToDouble(drOfabodotStam["theTimeToWrite"]);
            this.status = Convert.ToBoolean(drOfabodotStam["status"]);
            
        }

    }
}
