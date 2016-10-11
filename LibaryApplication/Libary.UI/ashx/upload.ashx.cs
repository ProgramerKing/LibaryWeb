using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Libary.UI.ashx
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //Get the data
            HttpPostedFile file = context.Request.Files["Filedata"];
            string filename = Path.GetFileName(file.FileName);
            string fileExt = Path.GetExtension(filename);
            if(fileExt==".jpg")
            {
                file.SaveAs(context.Request.MapPath("/uploadImg/"+filename));
                context.Response.Write("/uploadImg/" + filename);
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