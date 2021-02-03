using myblog.Models.utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
//using System.Web.Http;

namespace myblog.Controllers
{
    public class blogController : ApiController
    {
        //// GET: blog
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public DataTable GetArticals()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conn"].ToString();//引用的 using System.Configuration;
                sqlhelper shl = new sqlhelper(connectionString);
                string sql = "SELECT * FROM artical;";
                DataTable dt= shl.ExecuteDataTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //增加文章
        [HttpPost]
        public string AddArtical()
        {
            return "success";
        }

        //获取小心得
        [HttpGet]
        public DataTable GetExcerpt()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conn"].ToString();//引用的 using System.Configuration;
                sqlhelper shl = new sqlhelper(connectionString);
                string sql = "SELECT * FROM excerpt;";
                DataTable dt = shl.ExecuteDataTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}