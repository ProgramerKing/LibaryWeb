using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Libary.DBUtility;
using Libary.Models;

namespace Libary.DAL
{
    /// <summary>
    /// 数据访问类:R_UserInfo_ActionInfo
    /// </summary>
    public partial class R_UserInfo_ActionInfoDAL
    {
        public R_UserInfo_ActionInfoDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "R_UserInfo_ActionInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from R_UserInfo_ActionInfo");
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
        public int Add(R_UserInfo_ActionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into R_UserInfo_ActionInfo(");
            strSql.Append("IsPass,ActionInfoID,UserInfoID,ActionInfo_ID)");
            strSql.Append(" values (");
            strSql.Append("SQL2012IsPass,SQL2012ActionInfoID,SQL2012UserInfoID,SQL2012ActionInfo_ID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012IsPass", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012ActionInfoID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012UserInfoID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ActionInfo_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.IsPass;
            parameters[1].Value = model.ActionInfoID;
            parameters[2].Value = model.UserInfoID;
            parameters[3].Value = model.ActionInfo_ID;

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
        public bool Update(R_UserInfo_ActionInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update R_UserInfo_ActionInfo set ");
            strSql.Append("IsPass=SQL2012IsPass,");
            strSql.Append("ActionInfoID=SQL2012ActionInfoID,");
            strSql.Append("UserInfoID=SQL2012UserInfoID,");
            strSql.Append("ActionInfo_ID=SQL2012ActionInfo_ID");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012IsPass", SqlDbType.SmallInt,2),
                    new SqlParameter("SQL2012ActionInfoID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012UserInfoID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ActionInfo_ID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)};
            parameters[0].Value = model.IsPass;
            parameters[1].Value = model.ActionInfoID;
            parameters[2].Value = model.UserInfoID;
            parameters[3].Value = model.ActionInfo_ID;
            parameters[4].Value = model.ID;

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
            strSql.Append("delete from R_UserInfo_ActionInfo ");
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
            strSql.Append("delete from R_UserInfo_ActionInfo ");
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
        public R_UserInfo_ActionInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID from R_UserInfo_ActionInfo ");
            strSql.Append(" where ID=SQL2012ID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            R_UserInfo_ActionInfo model = new R_UserInfo_ActionInfo();
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
        public R_UserInfo_ActionInfo DataRowToModel(DataRow row)
        {
            R_UserInfo_ActionInfo model = new R_UserInfo_ActionInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["IsPass"] != null && row["IsPass"].ToString() != "")
                {
                    model.IsPass = int.Parse(row["IsPass"].ToString());
                }
                if (row["ActionInfoID"] != null && row["ActionInfoID"].ToString() != "")
                {
                    model.ActionInfoID = int.Parse(row["ActionInfoID"].ToString());
                }
                if (row["UserInfoID"] != null && row["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(row["UserInfoID"].ToString());
                }
                if (row["ActionInfo_ID"] != null && row["ActionInfo_ID"].ToString() != "")
                {
                    model.ActionInfo_ID = int.Parse(row["ActionInfo_ID"].ToString());
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
            strSql.Append("select ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID ");
            strSql.Append(" FROM R_UserInfo_ActionInfo ");
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
            strSql.Append(" ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID ");
            strSql.Append(" FROM R_UserInfo_ActionInfo ");
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
            strSql.Append("select count(1) FROM R_UserInfo_ActionInfo ");
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
            strSql.Append(")AS Row, T.*  from R_UserInfo_ActionInfo T ");
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
			parameters[0].Value = "R_UserInfo_ActionInfo";
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

