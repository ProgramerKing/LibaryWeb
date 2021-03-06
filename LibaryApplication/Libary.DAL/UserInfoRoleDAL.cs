﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:UserInfoRole
    /// </summary>
    public partial class UserInfoRoleDAL
    {
        public UserInfoRoleDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("UserInfo_ID", "UserInfoRole");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int UserInfo_ID, int Role_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserInfoRole");
            strSql.Append(" where UserInfo_ID=SQL2012UserInfo_ID and Role_ID=SQL2012Role_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012UserInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Role_ID", SqlDbType.Int,4)         };
            parameters[0].Value = UserInfo_ID;
            parameters[1].Value = Role_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(UserInfoRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into UserInfoRole(");
            strSql.Append("UserInfo_ID,Role_ID)");
            strSql.Append(" values (");
            strSql.Append("SQL2012UserInfo_ID,SQL2012Role_ID)");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012UserInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Role_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserInfo_ID;
            parameters[1].Value = model.Role_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UserInfoRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserInfoRole set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
            strSql.Append("UserInfo_ID=SQL2012UserInfo_ID,");
            strSql.Append("Role_ID=SQL2012Role_ID");
            strSql.Append(" where UserInfo_ID=SQL2012UserInfo_ID and Role_ID=SQL2012Role_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012UserInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Role_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserInfo_ID;
            parameters[1].Value = model.Role_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int UserInfo_ID, int Role_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from UserInfoRole ");
            strSql.Append(" where UserInfo_ID=SQL2012UserInfo_ID and Role_ID=SQL2012Role_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012UserInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Role_ID", SqlDbType.Int,4)         };
            parameters[0].Value = UserInfo_ID;
            parameters[1].Value = Role_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfoRole GetModel(int UserInfo_ID, int Role_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 UserInfo_ID,Role_ID from UserInfoRole ");
            strSql.Append(" where UserInfo_ID=SQL2012UserInfo_ID and Role_ID=SQL2012Role_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012UserInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Role_ID", SqlDbType.Int,4)         };
            parameters[0].Value = UserInfo_ID;
            parameters[1].Value = Role_ID;

            UserInfoRole model = new UserInfoRole();
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfoRole DataRowToModel(DataRow row)
        {
            UserInfoRole model = new UserInfoRole();
            if (row != null)
            {
                if (row["UserInfo_ID"] != null && row["UserInfo_ID"].ToString() != "")
                {
                    model.UserInfo_ID = int.Parse(row["UserInfo_ID"].ToString());
                }
                if (row["Role_ID"] != null && row["Role_ID"].ToString() != "")
                {
                    model.Role_ID = int.Parse(row["Role_ID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserInfo_ID,Role_ID ");
            strSql.Append(" FROM UserInfoRole ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" UserInfo_ID,Role_ID ");
            strSql.Append(" FROM UserInfoRole ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM UserInfoRole ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Role_ID desc");
            }
            strSql.Append(")AS Row, T.*  from UserInfoRole T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "UserInfoRole";
			parameters[1].Value = "Role_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

