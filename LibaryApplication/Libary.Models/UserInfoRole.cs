using System;
namespace Libary.Models
{
	/// <summary>
	/// UserInfoRole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserInfoRole
	{
		public UserInfoRole()
		{}
		#region Model
		private int _userinfo_id;
		private int _role_id;
		/// <summary>
		/// 
		/// </summary>
		public int UserInfo_ID
		{
			set{ _userinfo_id=value;}
			get{return _userinfo_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Role_ID
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		#endregion Model

	}
}

