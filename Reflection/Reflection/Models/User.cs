using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    public class User
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; }=null!;

        public string GetValue(string propName)
        {
            try
            {
                return this.GetType().GetProperty(propName).GetValue(this, null).ToString();
            }
            catch
            {
                return "This property does not exist";
            }
        }
    }
}
