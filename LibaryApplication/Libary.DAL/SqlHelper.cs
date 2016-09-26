using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DAL
{
    /// <summary>
    /// Sqlhelper 摘要说明
    /// </summary>
    public class SqlHelper
    {
        public static readonly string ConStr = DBUtility.ConnectionInfo.GetSqlServerConnectionString();

        #region 返回受影响的行数
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="cmdType">SQL类型</param>
        /// <param name="pms">参数组</param>
        /// <returns>int</returns>
        public static int ExecuteNonQuery(string sql,CommandType cmdType,params SqlParameter[]pms)
        {
            using (SqlConnection con=new SqlConnection(ConStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con)) 
                {
                    cmd.CommandType = cmdType;
                    if(pms!=null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 返回单个值
        /// <summary>
        /// 返回单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,CommandType cmdType,params SqlParameter[]pms)
        {
            using (SqlConnection con=new SqlConnection(ConStr))
            {
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    cmd.CommandType = cmdType;
                    if(pms!=null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region 返回DataReader
        /// <summary>
        /// 返回DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,CommandType cmdType,params SqlParameter[]pms)
        {
            SqlConnection con = new SqlConnection(ConStr);
            using (SqlCommand cmd=new SqlCommand(sql,con))
            {
                cmd.CommandType = cmdType;
                if(pms!=null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    if(con.State==ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }
        #endregion

        #region 执行返回DataTable
        /// <summary>
        /// 执行返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static DataTable ExecuteTable(string sql,CommandType cmdType,params SqlParameter[]pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter=new SqlDataAdapter(sql,ConStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if(pms!=null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
        #endregion
    }
}
