﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:Users
    /// </summary>
    public partial class UsersDAL
    {
        public UsersDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "Users");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Users");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Users(");
            strSql.Append("LoginId,LoginPwd,Name,Address,Phone,Mail,UserStateId)");
            strSql.Append(" values (");
            strSql.Append("SQL2012LoginId,SQL2012LoginPwd,SQL2012Name,SQL2012Address,SQL2012Phone,SQL2012Mail,SQL2012UserStateId)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012LoginId", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012LoginPwd", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012Name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012Address", SqlDbType.NVarChar,200),
                    new SqlParameter("SQL2012Phone", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012Mail", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012UserStateId", SqlDbType.Int,4)};
            parameters[0].Value = model.LoginId;
            parameters[1].Value = model.LoginPwd;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Address;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Mail;
            parameters[6].Value = model.UserStateId;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Users set ");
            strSql.Append("LoginId=SQL2012LoginId,");
            strSql.Append("LoginPwd=SQL2012LoginPwd,");
            strSql.Append("Name=SQL2012Name,");
            strSql.Append("Address=SQL2012Address,");
            strSql.Append("Phone=SQL2012Phone,");
            strSql.Append("Mail=SQL2012Mail,");
            strSql.Append("UserStateId=SQL2012UserStateId");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012LoginId", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012LoginPwd", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012Name", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012Address", SqlDbType.NVarChar,200),
                    new SqlParameter("SQL2012Phone", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012Mail", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012UserStateId", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)};
            parameters[0].Value = model.LoginId;
            parameters[1].Value = model.LoginPwd;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Address;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Mail;
            parameters[6].Value = model.UserStateId;
            parameters[7].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Users ");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Users ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Users GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,LoginId,LoginPwd,Name,Address,Phone,Mail,UserStateId from Users ");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Users DataRowToModel(DataRow row)
        {
            Users model = new Users();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["LoginId"] != null)
                {
                    model.LoginId = row["LoginId"].ToString();
                }
                if (row["LoginPwd"] != null)
                {
                    model.LoginPwd = row["LoginPwd"].ToString();
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }
                if (row["Mail"] != null)
                {
                    model.Mail = row["Mail"].ToString();
                }
                if (row["UserStateId"] != null && row["UserStateId"].ToString() != "")
                {
                    model.UserStateId = int.Parse(row["UserStateId"].ToString());
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
            strSql.Append("select Id,LoginId,LoginPwd,Name,Address,Phone,Mail,UserStateId ");
            strSql.Append(" FROM Users ");
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
            strSql.Append(" Id,LoginId,LoginPwd,Name,Address,Phone,Mail,UserStateId ");
            strSql.Append(" FROM Users ");
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
            strSql.Append("select count(1) FROM Users ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from Users T ");
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
			parameters[0].Value = "Users";
			parameters[1].Value = "Id";
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

