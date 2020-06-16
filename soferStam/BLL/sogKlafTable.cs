using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class sogKlafTable:genralTable
    {
        public sogKlafTable() : base("sogKlaf", "kodSogKlaf", true) { }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodSogKlaf"] = from["kodSogKlaf"];
            to["nameSogKlaf"] = from["nameSogKlaf"];
            to["status"] = from["status"];
            //to["price"] = from["price"];
            to.EndEdit();
           
        }

        public DataTable getSogeKlaf()
        {
            return DAL.dal.GetTableFromSQL("SELECT sogKlaf.kodSogKlaf, sogKlaf.nameSogKlaf FROM sogKlaf WHERE (((sogKlaf.status)=True)) ORDER BY sogKlaf.nameSogKlaf");
        }
    }
}
