using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC2_Sangue.Models;

namespace TCC2_Sangue.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return base.View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source= DESKTOP-RQ954A1; database= login; integrated security = SSPI; ";
        }
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login where username'" + acc.Email + "'and password='" + acc.Password + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return base.View();
            }
            else
            {
                con.Close();
                return base.View();
            }




        }

    }
}