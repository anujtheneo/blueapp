using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Blueapp.Models
{
    public class ItemModel
    {
        [Display(Name = "Items ID")]
        public int id { get; set; }

        [Display (Name = "Item Name")]
        public string name { get; set; }

        [Display (Name = "Upcoming Review")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime reviewDate { get; set; }

        [Display(Name = "Reminders")]
        public bool reminder { get; set; }

        [Display (Name = "Status")]
        public bool completionStatus { get; set; }

        [Display (Name = "Completion Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? completetionDate { get; set; }

        [Display(Name ="Item Type")]
        public string itemType { get; set; }

        [Display (Name = "Approvers")]
        public List<UserModel> approvers { get; set; }

        [Display (Name = "Distribution List")]
        public List<string> distributionList { get; set; }
    }
}