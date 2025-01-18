using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class UsersDto
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public List<string>? Permissions { get; set; }
    }
}
