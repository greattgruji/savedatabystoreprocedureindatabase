using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplicationmy.Models;

namespace WebApplicationmy.DAL
{
    public class EmployeeDAL
    {
        //private SqlConnection _oSqlConnection;
        //private SqlCommand _oSqlCommand;
        //public EmployeeDAL()
        //{
        //    _oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GoogleConnectionString"].ConnectionString);
        //    _oSqlCommand = new SqlCommand();
        //}
        public int save(Employee oEmployee)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = oEmployee.Name;

            param[1] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[1].Value = oEmployee.Email;

            param[2] = new SqlParameter("@ContactNo", SqlDbType.Int);
            param[2].Value = oEmployee.ContactNo;
            param[3] = new SqlParameter("@Subject", SqlDbType.VarChar, 50);
            param[3].Value = oEmployee.Subject;
            param[4] = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param[4].Value = oEmployee.Message;

            using (SqlConnection con = DataConnection.GetConnection())
            {
            return SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "Get_Employee", param);
            }



           //     _oSqlConnection.Open();
           // _oSqlCommand = new SqlCommand("Get_Employee", _oSqlConnection);
           // _oSqlCommand.CommandType = CommandType.StoredProcedure;
           //// _oSqlCommand.Parameters.AddWithValue("@Id", oEmployee.Name);
           // _oSqlCommand.Parameters.AddWithValue("@Name", oEmployee.Name);
           // _oSqlCommand.Parameters.AddWithValue("@Email", oEmployee.Email);
           // _oSqlCommand.Parameters.AddWithValue("@ContactNo", oEmployee.ContactNo);
           // _oSqlCommand.Parameters.AddWithValue("@Subject", oEmployee.Subject);
           // _oSqlCommand.Parameters.AddWithValue("@Message", oEmployee.Message);
           // _oSqlCommand.ExecuteNonQuery();
           // _oSqlConnection.Close();


        }
    }
}