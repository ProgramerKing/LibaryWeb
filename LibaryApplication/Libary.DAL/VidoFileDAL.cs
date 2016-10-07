using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:VidoFile
    /// </summary>
    public partial class VidoFileDAL
    {
        public VidoFileDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "VidoFile");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from VidoFile");
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
        public int Add(VidoFile model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into VidoFile(");
            strSql.Append("Title,FivPath,Status,FileExt)");
            strSql.Append(" values (");
            strSql.Append("SQL2012Title,SQL2012FivPath,SQL2012Status,SQL2012FileExt)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Title", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012FivPath", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012Status", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012FileExt", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.FivPath;
            parameters[2].Value = model.Status;
            parameters[3].Value = model.FileExt;

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
        public bool Update(VidoFile model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update VidoFile set ");
            strSql.Append("Title=SQL2012Title,");
            strSql.Append("FivPath=SQL2012FivPath,");
            strSql.Append("Status=SQL2012Status,");
            strSql.Append("FileExt=SQL2012FileExt");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Title", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012FivPath", SqlDbType.NVarChar,255),
                    new SqlParameter("SQL2012Status", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012FileExt", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.FivPath;
            parameters[2].Value = model.Status;
            parameters[3].Value = model.FileExt;
            parameters[4].Value = model.Id;

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
            strSql.Append("delete from VidoFile ");
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
            strSql.Append("delete from VidoFile ");
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
        public VidoFile GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Title,FivPath,Status,FileExt from VidoFile ");
            strSql.Append(" where Id=SQL2012Id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

            VidoFile model = new VidoFile();
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
        public VidoFile DataRowToModel(DataRow row)
        {
            VidoFile model = new VidoFile();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["FivPath"] != null)
                {
                    model.FivPath = row["FivPath"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
                }
                if (row["FileExt"] != null)
                {
                    model.FileExt = row["FileExt"].ToString();
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
            strSql.Append("select Id,Title,FivPath,Status,FileExt ");
            strSql.Append(" FROM VidoFile ");
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
            strSql.Append(" Id,Title,FivPath,Status,FileExt ");
            strSql.Append(" FROM VidoFile ");
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
            strSql.Append("select count(1) FROM VidoFile ");
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
            strSql.Append(")AS Row, T.*  from VidoFile T ");
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
			parameters[0].Value = "VidoFile";
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

