using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class mazminim
    {
        private int kodMaznim;
        public int KodMaznim
        {
            get { return kodMaznim; }
            set { kodMaznim = value; }
        }

        private string nameOfMazmin;
        public string NameOfMazmin
        {
            get { return nameOfMazmin; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם");
                else if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                else nameOfMazmin = value;
            }
        }

        private string NameOfFamily;
        public string NameOfFamily1
        {
            get { return NameOfFamily; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם");
                else if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                else NameOfFamily = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                // phoneNumber = value;
                if (validation.IsPhone(value) == true)
                    phoneNumber = value;
                else
                    throw new Exception("הקש מספר טלפון תקין");
            }

        }


        private string anotherPhone;
        public string AnotherPhone
        {
            get { return anotherPhone; }
            set
            {

                if (value == "")
                    anotherPhone = value;

                else if (validation.IsPhone(value) == true)
                    anotherPhone = value;

                else
                    throw new Exception("הקש מספר טלפון תקין");

            }
        }


        private string street;
        public string Street
        {
            get { return street; }
            set
            {
                if (value == "")
                    throw new Exception("הקש שם רחוב");
                else if (value[0] == ' ')
                    throw new Exception("שם לא מתחיל ברווח");
                else street = value;
            }
        }

        private int numberOfHouse;
        public int NumberOfHouse
        {
            get { return numberOfHouse; }
            set { numberOfHouse = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


        public mazminim() { this.status = true; }

        public mazminim(int kod, string name, string family, string phone, string another, string street, int num, string city)
        {
            this.kodMaznim = kod;
            this.nameOfMazmin = name;
            this.NameOfFamily = family;
            this.phoneNumber = phone;
            this.anotherPhone = another;
            this.street = street;
            this.numberOfHouse = num;
            this.city = city;
            this.status = true;
        }

        public mazminim(DataRow dr)
        {
            this.kodMaznim = Convert.ToInt32(dr["kodMaznim"]);
            this.nameOfMazmin = Convert.ToString(dr["nameOfMazmin"]);
            this.NameOfFamily = Convert.ToString(dr["NameOfFamily"]);
            this.phoneNumber = Convert.ToString(dr["phoneNumber"]);
            this.anotherPhone = Convert.ToString(dr["anotherPhone"]);
            this.street = Convert.ToString(dr["street"]);
            this.numberOfHouse = Convert.ToInt32(dr["numberOfHouse"]);
            this.city = Convert.ToString(dr["city"]);
            this.status = Convert.ToBoolean(dr["status"]);

        }

        public DataRow BuildRow()
        {
            DataTable dt = new mazminimTable().Dt;
            DataRow dr = dt.NewRow();
            dr["kodMaznim"] = this.kodMaznim;
            dr["nameOfMazmin"] = this.nameOfMazmin;
            dr["NameOfFamily"] = this.NameOfFamily;
            dr["phoneNumber"] = this.phoneNumber;
            dr["anotherPhone"] = this.anotherPhone;
            dr["street"] = this.street;
            dr["numberOfHouse"] = this.numberOfHouse;
            dr["city"] = this.city;
            dr["status"] = this.status;
            return dr;
        }
        public DataTable getNameLakoah(int codeMazmin)
        {
            DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.[kodMaznim], mazminim.[nameOfMazmin], mazminim.[NameOfFamily] FROM mazminim WHERE(((mazminim.[kodMaznim]) = " + codeMazmin + "))");
            //DataTable dt = DAL.dal.GetTableFromSQL("SELECT mazminim.[phoneNumber], mazminim.[nameOfMazmin], mazminim.[NameOfFamily] FROM mazminim WHERE (((mazminim.kodMaznim)=" + codeMazmin + "))");
            return dt ;
        }

    }
}
