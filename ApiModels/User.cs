using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWebApp.ApiModels
{
    public class User 
    {
        public string username { get; set; }
        public string first_name { get; set; }
        public string domain { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
