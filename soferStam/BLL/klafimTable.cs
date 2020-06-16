using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class klafimTable:genralTable
    {
        public klafimTable() : base("klafim", "kodKlaf", true) { }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodKlaf"] = from["kodKlaf"];
            to["nameOfKlaf"] = from["nameOfKlaf"];
            to["sizeOfKlaf"] = from["sizeOfKlaf"];
            to["status"] = from["status"];
            to.EndEdit();
           
        }
        public DataTable klafimForCombobox()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT klafim.kodKlaf, klafim.nameOfKlaf FROM klafim WHERE (((klafim.status)=True)) ORDER BY klafim.nameOfKlaf");
            return dt;
        }
    }
}
