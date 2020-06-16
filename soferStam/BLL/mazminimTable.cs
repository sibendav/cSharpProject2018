using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class mazminimTable:genralTable
    {
        public mazminimTable() : base("mazminim", "kodMaznim", true) { }
        public override void update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["kodMaznim"] = from["kodMaznim"];
            to["nameOfMazmin"] = from["nameOfMazmin"];
            to["NameOfFamily"] = from["NameOfFamily"];
            to["phoneNumber"] = from["phoneNumber"];
            to["anotherPhone"] = from["anotherPhone"];
            to["street"] = from["street"];
            to["numberOfHouse"] = from["numberOfHouse"];
            to["city"] = from["city"];
            to["status"]= from["status"];
            to.EndEdit();
           
        }
        public DataTable getPhones()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.kodMaznim, mazminim.phoneNumber FROM mazminim");
            return dt;
        }
        public DataTable getPirteyHazmana(int codeMazmin)
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT abodotStam.kodAboda,abodotStam.nameOfAboda, mazminim.kodMaznim, mazminim.nameOfMazmin, mazminim.NameOfFamily FROM mazminim INNER JOIN (hazmanot INNER JOIN (abodotStam INNER JOIN pirteHazmana ON abodotStam.kodAboda = pirteHazmana.kodAboda) ON hazmanot.kodHazmana = pirteHazmana.kodHazmana) ON mazminim.kodMaznim = hazmanot.kodMazmin WHERE (((mazminim.kodMaznim)=" + codeMazmin + "))");
            return dt;
        }
        public DataTable getFullName()
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.kodMaznim, mazminim.nameOfMazmin+' '+mazminim.NameOfFamily AS fullName FROM mazminim WHERE (((mazminim.status)=True)) ORDER BY mazminim.nameOfMazmin+' '+mazminim.NameOfFamily");
           // DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.[kodMaznim], mazminim.[nameOfMazmin], mazminim.[NameOfFamily] FROM mazminim WHERE(((mazminim.[kodMaznim]) =" +kod+ "))");
           // DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.[kodMaznim], mazminim.[nameOfMazmin], mazminim.[NameOfFamily] FROM mazminim WHERE(((mazminim.[kodMaznim]) = " + codeMazmin + "))");
           //DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.[phoneNumber], mazminim.[nameOfMazmin], mazminim.[NameOfFamily] FROM mazminim WHERE (((mazminim.kodMaznim)=" + codeMazmin + "))");
            return dt;
        }
        public DataTable getLakohot()
        {
            return DAL.dal.GetTableFromSQL("SELECT mazminim.kodMaznim, mazminim.nameOfMazmin+' '+ mazminim.NameOfFamily AS fullName FROM mazminim");
        }
    }
}
