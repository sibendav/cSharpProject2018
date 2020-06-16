using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace soferStam.DAL
{
    public static class dal
    {
        private static DataSet dsProject;
        private static OleDbConnection con;
        private static OleDbDataAdapter[] adapters;
        private static string[] tableNames = new string[] { "abodotStam", "hazmanot", "hespekim", "klafim", "mazminim", "pirteHazmana", "sogKlaf" };
        //private static string dbpath = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + System.IO.Directory.GetCurrentDirectory() + @"\2003simkha.mdb"; //מחשב של אוחיון
        //@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + @"\simkha.accdb"; //לא תקין!!!
        //private static string dbpath=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "+System.IO.Directory.GetCurrentDirectory()+@"\simkha1.accdb"; //בתיכון
        //private static string dbpath = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+System.IO.Directory.GetCurrentDirectory()+@"\2003simkha.mdb"; //בלוסטיג
        private static string dbpath = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() +@"\simkha.accdb";


        public static void ConnectToDB()
        {
            dsProject = new DataSet();

            con = new OleDbConnection(dbpath);

            adapters = new OleDbDataAdapter[tableNames.Length];

            for (int i = 0; i < adapters.Length; i++)
            {
                adapters[i] = new OleDbDataAdapter("select * from " + tableNames[i], con);
                adapters[i].Fill(dsProject, tableNames[i]);
                // בנית פקודות לעדכון
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapters[i]);
                adapters[i].InsertCommand = builder.GetInsertCommand();
                adapters[i].UpdateCommand = builder.GetUpdateCommand();
                adapters[i].DeleteCommand = builder.GetDeleteCommand();
            }
        }

        public static DataTable GetTable(string tableName)
        {
            return dsProject.Tables[tableName];
        }
        public static DataTable GetTableFromSQL(string sqlSelect)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static void Update()
        {
            for (int i = 0; i < tableNames.Length; i++)
            {
               // if (tableNames[i] == tableName)
                    adapters[i].Update(dsProject, tableNames[i] );
            }
        }

    }
}
