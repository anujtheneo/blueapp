using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blueapp.Models
{
    public class UserModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public bool superuser { get; set; }
    }
}