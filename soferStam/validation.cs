
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soferStam
{
    public enum statusKind { show, delet, update, add, addAndBack, updateAndBack, addAndUpdate, showRow , showMonth, Showyear};

    public class validation
    {
        public static bool IsID(string id)//שיטה הבודקת תקינות תעודת זהות ישראלית
        {
            if (id.Length < 9)
            {
                for (int i = 0; i < 9 - id.Length; i++)
                {
                    id = "0" + id;
                }
            }
            int sum = 0;
            int temp;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    sum += Convert.ToInt32(id[i].ToString());
                }
                else
                {
                    temp = Convert.ToInt32(id[i].ToString()) * 2;
                    if (temp > 9)
                    {
                        temp = temp / 10 + temp % 10;
                    }
                    sum += temp;
                }

            }
            if (sum % 10 == 0)
                return true;
            else
                return false;
        }

        public static bool IsNum(char p)//שיטה הבודקת תקינות מספר
        {
            if ((p >= '0') && (p <= '9'))
                return true;
            else return false;
        }

        public static bool IsHebrew(char ot)//שיטה הבודקת תקינות אותיות בעברית
        {
            if (ot >= 'א' && ot <= 'ת')
                return true;
            else return false;
        }

        public static bool IsPhone(string p)//שיטה הבודקת תקינות מספר טלפון
        {
            if (p[0] == 48 && (p.Length == 9 ||  p.Length == 10))
                return true;
            else return false;
        }
    }
}
