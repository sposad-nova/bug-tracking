using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bug_tracking_system
{
    class IntemList
    {
        int intem;
        string projUser;

        public IntemList(int intem, string projUser) 
        {
            this.intem = intem;
            this.projUser = projUser;
        }

        public string Add()
        {

            string sqlQuery;

            switch (intem)
            {
                case 0:
                    sqlQuery = "SELECT * FROM Users";
                    break;
                case 1:
                    sqlQuery = "SELECT * FROM Projects";
                    break;
                case 2:
                    sqlQuery = $@"SELECT * FROM Tasks WHERE project = '{projUser}'";
                    break;
                case 3:
                    sqlQuery = $@"SELECT * FROM Tasks WHERE user = '{projUser}'";
                    break;
                default:
                    sqlQuery = "SELECT * FROM Users";
                    break;
            }
            
            return sqlQuery;
        }         
    }
}


