using Libary.DBUtility;
using Libary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DAL
{
    public partial class UsersDAL
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Users GetModel(string userName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,LoginId,LoginPwd,Name,Address,Phone,Mail,UserStateId from Users ");
            strSql.Append(" where LoginId=@LoginId");
            SqlParameter[] parameters = {
                    new SqlParameter("@LoginId", SqlDbType.NVarChar,50)
            };
            parameters[0].Value = userName;

            Users model = new Users();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public int CheckUserMail(string mail)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Mail=@Mail";
            return Convert.ToInt32(DbHelperSQL.GetSingle(sql, new SqlParameter("@Mail", mail)));
        }
    }
}
