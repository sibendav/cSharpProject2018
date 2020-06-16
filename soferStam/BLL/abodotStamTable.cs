using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class abodotStamTable:genralTable
    {
        public abodotStamTable() : base("abodotStam", "kodAboda", true) { }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodAboda"] = from["kodAboda"];
            to["nameOfAboda"] = from["nameOfAboda"];
            to["kodKlaf"] = from["kodKlaf"];
            to["amountOfKlafim"] = from["amountOfKlafim"];
            to["writingType"] = from["writingType"];
            to["theTimeToWrite"] = from["theTimeToWrite"];
            to["status"] = from["status"];
            to.EndEdit();
           
        }
        public DataTable getAbodotStam()
        {
            return DAL.dal.GetTableFromSQL("SELECT abodotStam.kodAboda, abodotStam.nameOfAboda FROM abodotStam WHERE (((abodotStam.status)=True)) ORDER BY abodotStam.nameOfAboda");
        }
    }
}
