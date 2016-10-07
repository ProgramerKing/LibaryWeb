﻿using System;
using System.Data;
using System.Collections.Generic;
using Libary.DAL;
using Libary.Models;
namespace Libary.BLL
{
	/// <summary>
	/// RoleActionGroup
	/// </summary>
	public partial class RoleActionGroupService
    {
		private readonly  RoleActionGroupDAL dal=new RoleActionGroupDAL();
		public RoleActionGroupService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Role_ID,int ActionGroup_ID)
		{
			return dal.Exists(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add( RoleActionGroup model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update( RoleActionGroup model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Role_ID,int ActionGroup_ID)
		{
			
			return dal.Delete(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public  RoleActionGroup GetModel(int Role_ID,int ActionGroup_ID)
		{
			
			return dal.GetModel(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public  RoleActionGroup GetModelByCache(int Role_ID,int ActionGroup_ID)
		{
			
			string CacheKey = "RoleActionGroupModel-" + Role_ID+ActionGroup_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Role_ID,ActionGroup_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return ( RoleActionGroup)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List< RoleActionGroup> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List< RoleActionGroup> DataTableToList(DataTable dt)
		{
			List< RoleActionGroup> modelList = new List< RoleActionGroup>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				 RoleActionGroup model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

