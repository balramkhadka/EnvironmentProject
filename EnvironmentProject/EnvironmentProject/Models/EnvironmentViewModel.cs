using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnvironmentProject.Models
{
    public class EnvironmentViewModel
    {
        public string HostName { get; set; }
        public string DatabaseName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Region { get; set; }

    }
}