using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:ActionInfo
    /// </summary>
    public partial class ActionInfoDAL
    {
        public ActionInfoDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "ActionInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ActionInfo");
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
        public int Add(ActionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ActionInfo(");
            strSql.Append("ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID)");
            strSql.Append(" values (");
            strSql.Append("SQL2012ActionInfoName,SQL2012Url,SQL2012HttpMethod,SQL2012Remark,SQL2012DelFalg,SQL2012SubTime,SQL2012IsMenu,SQL2012R_UserInfo_ActionInfoID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ActionInfoName", SqlDbType.NVarChar,32),
                    new SqlParameter("SQL2012Url", SqlDbType.VarChar,256),
                    new SqlParameter("SQL2012HttpMethod", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,256),
                    new SqlParameter("SQL2012DelFalg", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012SubTime", SqlDbType.DateTime),
                    new SqlParameter("SQL2012IsMenu", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012R_UserInfo_ActionInfoID", SqlDbType.Int,4)};
            parameters[0].Value = model.ActionInfoName;
            parameters[1].Value = model.Url;
            parameters[2].Value = model.HttpMethod;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.DelFalg;
            parameters[5].Value = model.SubTime;
            parameters[6].Value = model.IsMenu;
            parameters[7].Value = model.R_UserInfo_ActionInfoID;

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
        public bool Update(ActionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ActionInfo set ");
            strSql.Append("ActionInfoName=SQL2012ActionInfoName,");
            strSql.Append("Url=SQL2012Url,");
            strSql.Append("HttpMethod=SQL2012HttpMethod,");
            strSql.Append("Remark=SQL2012Remark,");
            strSql.Append("DelFalg=SQL2012DelFalg,");
            strSql.Append("SubTime=SQL2012SubTime,");
            strSql.Append("IsMenu=SQL2012IsMenu,");
            strSql.Append("R_UserInfo_ActionInfoID=SQL2012R_UserInfo_ActionInfoID");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ActionInfoName", SqlDbType.NVarChar,32),
                    new SqlParameter("SQL2012Url", SqlDbType.VarChar,256),
                    new SqlParameter("SQL2012HttpMethod", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,256),
                    new SqlParameter("SQL2012DelFalg", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012SubTime", SqlDbType.DateTime),
                    new SqlParameter("SQL2012IsMenu", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012R_UserInfo_ActionInfoID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ActionInfoName;
            parameters[1].Value = model.Url;
            parameters[2].Value = model.HttpMethod;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.DelFalg;
            parameters[5].Value = model.SubTime;
            parameters[6].Value = model.IsMenu;
            parameters[7].Value = model.R_UserInfo_ActionInfoID;
            parameters[8].Value = model.ID;

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
            strSql.Append("delete from ActionInfo ");
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
            strSql.Append("delete from ActionInfo ");
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
        public ActionInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID from ActionInfo ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            ActionInfo model = new ActionInfo();
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
        public ActionInfo DataRowToModel(DataRow row)
        {
            ActionInfo model = new ActionInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["ActionInfoName"] != null)
                {
                    model.ActionInfoName = row["ActionInfoName"].ToString();
                }
                if (row["Url"] != null)
                {
                    model.Url = row["Url"].ToString();
                }
                if (row["HttpMethod"] != null && row["HttpMethod"].ToString() != "")
                {
                    model.HttpMethod = int.Parse(row["HttpMethod"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["DelFalg"] != null && row["DelFalg"].ToString() != "")
                {
                    model.DelFalg = int.Parse(row["DelFalg"].ToString());
                }
                if (row["SubTime"] != null && row["SubTime"].ToString() != "")
                {
                    model.SubTime = DateTime.Parse(row["SubTime"].ToString());
                }
                if (row["IsMenu"] != null && row["IsMenu"].ToString() != "")
                {
                    if ((row["IsMenu"].ToString() == "1") || (row["IsMenu"].ToString().ToLower() == "true"))
                    {
                        model.IsMenu = true;
                    }
                    else
                    {
                        model.IsMenu = false;
                    }
                }
                if (row["R_UserInfo_ActionInfoID"] != null && row["R_UserInfo_ActionInfoID"].ToString() != "")
                {
                    model.R_UserInfo_ActionInfoID = int.Parse(row["R_UserInfo_ActionInfoID"].ToString());
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
            strSql.Append("select ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID ");
            strSql.Append(" FROM ActionInfo ");
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
            strSql.Append(" ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID ");
            strSql.Append(" FROM ActionInfo ");
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
            strSql.Append("select count(1) FROM ActionInfo ");
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
            strSql.Append(")AS Row, T.*  from ActionInfo T ");
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
			parameters[0].Value = "ActionInfo";
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

