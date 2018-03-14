using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;


namespace Bank
{
    public class Data
    {
        static string xmlFile = "userData.xml";
        private DataSet dataSet = new DataSet();
        
        protected Data()
        {
            this.dataSet.ReadXml(xmlFile, XmlReadMode.InferSchema);
        }
        static private List<string> userList = new List<string>
        {
            "vasya0102",
            "dima1993",
            "xkirilx",
            "valera11",
            "domava",
            "arava",
            "busy"
        };

        protected bool Authorization(string name, string pass, ref DataRow user, ref List<DataRow> account)
        {
            int user_id = userList.IndexOf(name);
            if (user_id != -1)
            {
                int k = 0;
                DataRow count;
                user = dataSet.Tables[0].Rows[user_id];
                for(int i = 0; i < user_id; i++)
                {
                    count = dataSet.Tables[0].Rows[i];
                    k += int.Parse(count[4].ToString());
                }
                count = dataSet.Tables[0].Rows[user_id];
                for(int i = 0; i < int.Parse(count[4].ToString()); i++)
                {
                    account.Add(dataSet.Tables[1].Rows[k]);
                    k++;
                }
                var rows = dataSet.Tables[0].Rows[user_id];
                if (pass == rows[1].ToString())
                {
                    Console.WriteLine(rows[0]);
                    return true;
                }
            }
            return false;
        }
    }
}
