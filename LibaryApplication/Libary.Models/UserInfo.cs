using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string User_Name { get; set; }
        public string User_Pwd { get; set; }
        public string User_Email { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
