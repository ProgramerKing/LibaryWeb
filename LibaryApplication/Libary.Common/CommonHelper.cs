namespace Libary.Common
{
    using System.Security.Cryptography;
    using System.Text;

    public class CommonHelper
    {
        public string GetMd5(string txtStr)
        {
            //1.创建MD5对象
            MD5 md5 = MD5.Create();
            //2.将字符串转成字节数组
            byte[] buffers = Encoding.UTF8.GetBytes(txtStr);
            //3.加密
            byte[] bytesMd5 = md5.ComputeHash(buffers);
            //4.将字节数组转换成字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytesMd5.Length; i++)
            {
                sb.Append(bytesMd5[i].ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
