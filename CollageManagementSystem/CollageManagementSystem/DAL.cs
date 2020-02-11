using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CollageManagementSystem.Models;

namespace CollageManagementSystem
{
    public class DAL
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


        public int userlogin(Login us)
        {

            SqlCommand com = new SqlCommand("Sp_User_login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Email", us.email);
            com.Parameters.AddWithValue("@Password", us.password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.Direction = ParameterDirection.Output;
            oblogin.SqlDbType = SqlDbType.Bit;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;

        }

    }





}