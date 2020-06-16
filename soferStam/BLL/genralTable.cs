using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace soferStam.BLL
{
    public class genralTable
    {
        protected DataTable dt;
        public  DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        protected string keyName;
        public string KeyName
        {
            get { return keyName; }
            set { keyName = value; }
        }

        protected bool isStatus;
        public bool IsStatus
        {
            get { return isStatus; }
            set { isStatus = value; }
        }

        public genralTable(string nameTbl, string kname, bool isSta)//בונה ג'נרל טייבל
        {
            this.dt = DAL.dal.GetTable(nameTbl);
            this.keyName = kname;
            this.isStatus = isSta;

        }

        public DataTable GetTableTrue()// ומייבא אותה מ ACCESS בודק אם הטבלה מנוהלת על פי סטטוס 
        {
            if (this.isStatus == true)
                return DAL.dal.GetTableFromSQL("select * from " + this.dt.TableName + " where status = true");
            else return DAL.dal.GetTableFromSQL("select * from " + this.dt.TableName);

        }

        public DataRow Find(object valueOfKey)//
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[this.keyName].Equals(valueOfKey))
                    if (this.isStatus.Equals(true))
                        if (dr["status"].Equals(true))
                            return dr;
                        else return null;
                    else return dr;

            }
            return null;
        }

        public bool Add(DataRow rowToAdd)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (IsSameKeys(rowToAdd, dr))// לבדוק אם יש כפל
                    if (this.isStatus.Equals(true))
                        if (dr["status"].Equals(true))
                            return false;
                        else 
                        {
                            update(rowToAdd, dr);
                            DAL.dal.Update();
                            return true;
                        }
                    else return false;
            }
            this.dt.Rows.Add(rowToAdd);
            DAL.dal.Update();
            return true;
        }

        public virtual void update(DataRow from, DataRow to) { }

        public bool Delete(DataRow rowToDelete)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (IsSameKeys(rowToDelete, dr))
                    if (this.isStatus.Equals(true))
                    {
                        dr["status"] = false;
                        DAL.dal.Update();
                        return true;
                    }
                    else
                    {
                        dr.Delete();
                        DAL.dal.Update();
                        return true;
                    }
            }
            return false;
        }

        public bool update(DataRow drToUpdate)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (IsSameKeys(drToUpdate, dr))
                    if (this.isStatus.Equals(true) && (dr["status"].Equals(false)))
                        return false;
                    else
                    {
                        update(drToUpdate, dr);
                        DAL.dal.Update();
                        return true;
                    }
            }
            return false;
        }

        public int GetNextCode()
        {
            int max = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr[this.keyName]) > max)
                    max = Convert.ToInt32(dr[this.keyName]);
            }
            return max + 1;
        }

        public DataTable getTableForComboBox(string fieldName)
        {
            string st;
            if (this.isStatus == true)
                st = "SELECT " + this.keyName + ", [" + fieldName + "] & '-' & [" + keyName + "] AS  fullName FROM " + dt.TableName + " where status=true";
            else
                st = "SELECT " + this.keyName + ", [" + fieldName + "] AS  fullName FROM " + dt.TableName;
                //st = "SELECT " + this.keyName + ", [" + fieldName + "] & '-' & [" + keyName + "] AS  fullName FROM " + dt.TableName;

            return DAL.dal.GetTableFromSQL(st);
         


        }

        public DataTable getTableForComboBox(string fieldName1,string fieldName2)
        {
            string st;
            if (this.isStatus == true)
                st = " SELECT " + this.keyName + " , [ " + fieldName1 + " ] &[ " + fieldName2 + " ]& '-' & [ " + keyName + " ] AS  fullName FROM " + dt.TableName + " where status=true";
            else
                st = "SELECT " + this.keyName + " , [ " + fieldName1 + " ] &[ " + fieldName2 + " ] AS  fullName FROM " + dt.TableName;
                //st = " SELECT " + this.keyName + " , [ " + fieldName1 + " ] &[ " + fieldName2 + " ]& '-' & [ " + keyName + " ] AS  fullName FROM " + dt.TableName;

            return DAL.dal.GetTableFromSQL(st);



        }

        public virtual bool IsSameKeys(DataRow dr1, DataRow dr2)
        {
            return dr1[this.keyName].Equals(dr2[this.keyName]);
        }
            
    

    }
}
