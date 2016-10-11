using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        #region MD5签名加密
        public static string Md5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] md5Buffer = md5.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in md5Buffer)
            {
                sb.Append(b.ToString("x2"));
            }
            md5.Clear(); //释放资源
            return sb.ToString();
        } 
        #endregion

    }
}
