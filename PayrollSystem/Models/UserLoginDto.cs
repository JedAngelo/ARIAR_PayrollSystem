using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class UserLoginDto
    {
        public string userID { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string UserToken { get; set; }
        //public string newRefreshToken { get; set; }
        public IList<string>? UserRole { get; set; }
        public List<string>? Permissions { get; set; }
    }

}
