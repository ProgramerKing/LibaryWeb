using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libary.UI.ashx
{
    /// <summary>
    /// CheckUserName 的摘要说明
    /// </summary>
    public class CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["userName"];
            Libary.BLL.UsersService userBll = new BLL.UsersService();
            if (userBll.GetModel(userName) != null)
            {
                context.Response.Write("Y");
            }
            else
            {
                context.Response.Write("N");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}