using Libary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libary.UI.ashx
{
    /// <summary>
    /// CheckUserMail 的摘要说明
    /// </summary>
    public class CheckUserMail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string mail = context.Request["mail"];
            UsersService users = new UsersService();
            if(users.CheckUserMail(mail))
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