using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Libary.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class WebCommon
    {
        /// <summary>
        /// 完成验证码的校验
        /// </summary>
        /// <returns></returns>
        public static bool CheckValidateCode()
        {
            HttpContext context = HttpContext.Current;
            bool isSuccess = false;
            if(context.Session["vCode"]!=null)
            {
                string code = context.Request["code"];
                string sysCode = context.Session["vCode"].ToString();
                if(sysCode.Equals(code,StringComparison.InvariantCultureIgnoreCase))
                {
                    //context.Session["vCode"] = null;
                    isSuccess = true;
                }
            }
            return isSuccess;
        }
    }
}
