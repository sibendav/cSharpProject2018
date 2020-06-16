using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    class GenralTableTwoKeys:genralTable
    {
        private string anotherKname;
        public GenralTableTwoKeys(String nameTbl, String Kname1, String Kname2, bool isSta)
            : base(nameTbl, Kname1, isSta)
        {
            this.anotherKname = Kname2;
        }

        public DataRow Find(string Kname1, object valueOfKey1, string Kname2, object valueOfKey2)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[Kname1].Equals(valueOfKey1) && dr[Kname2].Equals(valueOfKey2))
                    if (this.isStatus.Equals(true))
                        if (dr["status"].Equals(true))
                            return dr;
                        else return null;
                    else return dr;

            }
            return null;
        }

        public override bool IsSameKeys(DataRow dr1, DataRow dr2)
        {
            return base.IsSameKeys(dr1, dr2) && dr1[this.anotherKname].Equals(dr2[this.anotherKname]);
        }

    }
}
