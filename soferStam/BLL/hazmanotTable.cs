using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class hazmanotTable : genralTable
    {
        public hazmanotTable() : base("hazmanot", "kodHazmana", false) { }

        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodHazmana"] = from["kodHazmana"];
            to["dateHazmana"] = from["dateHazmana"];
            to["kodMazmin"] = from["kodMazmin"];
            // to["amountOfTime"] = from["amountOfTime"];
            to.EndEdit();
        }
        public DataTable hazmnotImMazminim()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT hespekim.kodHespek, hespekim.kodParitHazmana, pirteHazmana.kodPirteyHazmana, mazminim.kodMaznim, mazminim.nameOfMazmin, mazminim.NameOfFamily FROM((mazminim INNER JOIN hazmanot ON mazminim.[kodMaznim] = hazmanot.[kodMazmin]) INNER JOIN pirteHazmana ON hazmanot.[kodHazmana] = pirteHazmana.[kodHazmana]) INNER JOIN hespekim ON pirteHazmana.[kodPirteyHazmana] = hespekim.[kodParitHazmana] ");
            return dt;
        }

        public DataTable GetMazminiHazmanotLePirteHazmana()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.nameOfMazmin, mazminim.NameOfFamily FROM mazminim INNER JOIN hazmanot ON mazminim.[kodMaznim] = hazmanot.[kodMazmin] ");
            return dt;
        }
        public DataTable getAllHazmanot(int kodMazmin)
        {
            return DAL.dal.GetTableFromSQL("SELECT hazmanot.kodHazmana, hazmanot.dateHazmana, hazmanot.kodMazmin FROM hazmanot WHERE (((hazmanot.kodMazmin)="+kodMazmin+"))");
        }

    }
}
