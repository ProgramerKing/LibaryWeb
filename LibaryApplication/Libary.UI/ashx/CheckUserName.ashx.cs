using Libary.BLL;
using Libary.Common;
using Libary.Models;
using Libary.Models.EnumClass;
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
            if(WebCommon.CheckValidateCode())
            {
                context.Session["vCode"] = null;
                UserRegister(context);
            }
            else
            {

            }

        }

        /// <summary>
        /// 完成注册
        /// </summary>
        /// <returns></returns>
        private bool UserRegister(HttpContext context)
        {
            Users user = new Users();
            user.Address = context.Request["txtAddress"];
            user.LoginId = context.Request["txtName"];
            user.LoginPwd = context.Request["txtLoginPwd"];
            user.Mail = context.Request["txtMail"];
            user.Name = context.Request["txtRealName"];
            user.Phone = context.Request["txtPhone"];
            user.UserStateId = Convert.ToInt32(UserStaateEnum.UserNormarl);
            UsersService userBll = new UsersService();
            return true;
            
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