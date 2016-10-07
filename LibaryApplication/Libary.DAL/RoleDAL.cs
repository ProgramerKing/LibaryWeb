﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:Role
    /// </summary>
    public partial class RoleDAL
    {
        public RoleDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "Role");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Role");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Role(");
            strSql.Append("RoleName,DelFlag,RoleType,SubTime,Remark)");
            strSql.Append(" values (");
            strSql.Append("SQL2012RoleName,SQL2012DelFlag,SQL2012RoleType,SQL2012SubTime,SQL2012Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012RoleName", SqlDbType.NVarChar,12),
                    new SqlParameter("SQL2012DelFlag", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012RoleType", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012SubTime", SqlDbType.DateTime),
                    new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,256)};
            parameters[0].Value = model.RoleName;
            parameters[1].Value = model.DelFlag;
            parameters[2].Value = model.RoleType;
            parameters[3].Value = model.SubTime;
            parameters[4].Value = model.Remark;

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
        public bool Update(Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Role set ");
            strSql.Append("RoleName=SQL2012RoleName,");
            strSql.Append("DelFlag=SQL2012DelFlag,");
            strSql.Append("RoleType=SQL2012RoleType,");
            strSql.Append("SubTime=SQL2012SubTime,");
            strSql.Append("Remark=SQL2012Remark");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012RoleName", SqlDbType.NVarChar,12),
                    new SqlParameter("SQL2012DelFlag", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012RoleType", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012SubTime", SqlDbType.DateTime),
                    new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,256),
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)};
            parameters[0].Value = model.RoleName;
            parameters[1].Value = model.DelFlag;
            parameters[2].Value = model.RoleType;
            parameters[3].Value = model.SubTime;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.ID;

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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Role ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Role ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public Role GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,RoleName,DelFlag,RoleType,SubTime,Remark from Role ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            Role model = new Role();
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
        public Role DataRowToModel(DataRow row)
        {
            Role model = new Role();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["RoleName"] != null)
                {
                    model.RoleName = row["RoleName"].ToString();
                }
                if (row["DelFlag"] != null && row["DelFlag"].ToString() != "")
                {
                    model.DelFlag = int.Parse(row["DelFlag"].ToString());
                }
                if (row["RoleType"] != null && row["RoleType"].ToString() != "")
                {
                    model.RoleType = int.Parse(row["RoleType"].ToString());
                }
                if (row["SubTime"] != null && row["SubTime"].ToString() != "")
                {
                    model.SubTime = DateTime.Parse(row["SubTime"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
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
            strSql.Append("select ID,RoleName,DelFlag,RoleType,SubTime,Remark ");
            strSql.Append(" FROM Role ");
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
            strSql.Append(" ID,RoleName,DelFlag,RoleType,SubTime,Remark ");
            strSql.Append(" FROM Role ");
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
            strSql.Append("select count(1) FROM Role ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from Role T ");
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
			parameters[0].Value = "Role";
			parameters[1].Value = "ID";
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

