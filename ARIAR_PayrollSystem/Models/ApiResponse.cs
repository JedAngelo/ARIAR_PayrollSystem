using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public bool isSuccess { get; set; }
    }
}
