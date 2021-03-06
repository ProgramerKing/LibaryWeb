﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:keyWordsRank
    /// </summary>
    public partial class KeyWordsRankDAL
    {
        public KeyWordsRankDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from keyWordsRank");
            strSql.Append(" where Id=SQL2012Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.UniqueIdentifier,16)            };
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(KeyWordsRank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into keyWordsRank(");
            strSql.Append("Id,KeyWords,SearchTimes)");
            strSql.Append(" values (");
            strSql.Append("SQL2012Id,SQL2012KeyWords,SQL2012SearchTimes)");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.UniqueIdentifier,16),
                    new SqlParameter("SQL2012KeyWords", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012SearchTimes", SqlDbType.Int,4)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.KeyWords;
            parameters[2].Value = model.SearchTimes;

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
        public bool Update(KeyWordsRank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update keyWordsRank set ");
            strSql.Append("KeyWords=SQL2012KeyWords,");
            strSql.Append("SearchTimes=SQL2012SearchTimes");
            strSql.Append(" where Id=SQL2012Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012KeyWords", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012SearchTimes", SqlDbType.Int,4),
                    new SqlParameter("SQL2012Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.KeyWords;
            parameters[1].Value = model.SearchTimes;
            parameters[2].Value = model.Id;

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
        public bool Delete(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from keyWordsRank ");
            strSql.Append(" where Id=SQL2012Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.UniqueIdentifier,16)            };
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
            strSql.Append("delete from keyWordsRank ");
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
        public KeyWordsRank GetModel(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,KeyWords,SearchTimes from keyWordsRank ");
            strSql.Append(" where Id=SQL2012Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.UniqueIdentifier,16)            };
            parameters[0].Value = Id;

            KeyWordsRank model = new KeyWordsRank();
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
        public KeyWordsRank DataRowToModel(DataRow row)
        {
            KeyWordsRank model = new KeyWordsRank();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = new Guid(row["Id"].ToString());
                }
                if (row["KeyWords"] != null)
                {
                    model.KeyWords = row["KeyWords"].ToString();
                }
                if (row["SearchTimes"] != null && row["SearchTimes"].ToString() != "")
                {
                    model.SearchTimes = int.Parse(row["SearchTimes"].ToString());
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
            strSql.Append("select Id,KeyWords,SearchTimes ");
            strSql.Append(" FROM keyWordsRank ");
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
            strSql.Append(" Id,KeyWords,SearchTimes ");
            strSql.Append(" FROM keyWordsRank ");
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
            strSql.Append("select count(1) FROM keyWordsRank ");
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
            strSql.Append(")AS Row, T.*  from keyWordsRank T ");
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
			parameters[0].Value = "keyWordsRank";
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

