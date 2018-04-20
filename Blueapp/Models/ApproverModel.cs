using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blueapp.Models
{
    public class ApproverModel
    {
        public int itemID { get; set; }
        public string userID { get; set; }
        public int status { get; set; }
    }
}