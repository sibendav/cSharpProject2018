using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class hespekimTable:genralTable
    {
        public hespekimTable() : base("hespekim", "kodHespek", false) { }

        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodHespek"] = from["kodHespek"];
            to["kodParitHazmana"] = from["kodParitHazmana"];
            //to["kodAboda"] = from["kodAboda"];
            to["theDate"]=from["theDate"];
            to["fromTime"] = from["fromTime"];
            to["tillTime"] = from["tillTime"];
            to.EndEdit();
        }
        public DataTable getHespekimForCmb()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT hespekim.kodHespek, mazminim.nameOfMazmin+' '+mazminim.NameOfFamily+'-'+ abodotStam.nameOfAboda+'-'+ hespekim.theDate FROM abodotStam INNER JOIN (mazminim INNER JOIN (hazmanot INNER JOIN (pirteHazmana INNER JOIN hespekim ON pirteHazmana.kodPirteyHazmana = hespekim.kodParitHazmana) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin) ON abodotStam.kodAboda = pirteHazmana.kodAboda WHERE (((hespekim.kodHespek)=20))");
            return dt;
        }
    }
}
