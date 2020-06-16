using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class pirteHazmanaTable:genralTable
    {
        public pirteHazmanaTable() : base("pirteHazmana", "kodPirteyHazmana", false) { }//אולי יש צורך להחליף את הסטטוס לבדוק ע"י הרצות

        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodPirteyHazmana"] = from["kodPirteyHazmana"];
            to["kodHazmana"] = from["kodHazmana"];
            //to["kodPirteyHazmana"] = from["kodPirteyHazmana"];
            to["kodAboda"] = from["kodAboda"];
            to["destinationDate"] = from["destinationDate"];
            to["amount"] = from["amount"];
            to["kodSogKlaf"] = from["kodSogKlaf"];
            to["price"] = from["price"];
            to["status"] = from["status"];
            to.EndEdit();
           
        }

          public double getNumWorkHour(int codeParitHazmana)
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT abodotStam.theTimeToWrite FROM abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((pirteHazmana.kodPirteyHazmana)=" + codeParitHazmana + "))");
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                return Convert.ToDouble(dr["theTimeToWrite"]);
            }
            return 0;
        }

          public DataTable getPirteyHazmanaByHazmana(int code)
          {
              return DAL.dal.GetTableFromSQL("SELECT pirteHazmana.* FROM pirteHazmana WHERE (((pirteHazmana.kodHazmana)="+code+"))");
          }


        

    }
}
