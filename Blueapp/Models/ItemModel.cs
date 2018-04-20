using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blueapp.Models
{
    public class ItemModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime reviewDate { get; set; }
        public bool reminder { get; set; }
        public bool completionStatus { get; set; }
        public DateTime? completetionDate { get; set; }
    }
}