using Libary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.BLL
{
    public partial class UsersService
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Users GetModel(string userName)
        {
            return dal.GetModel(userName);
        }
    }
}
