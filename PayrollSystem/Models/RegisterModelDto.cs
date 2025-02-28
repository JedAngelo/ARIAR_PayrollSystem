using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class RegisterModelDto
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? CurrentPassword { get; set; }
        public List<PermissionDto>? PermissionDtos { get; set; } = new List<PermissionDto>();
    }
}
