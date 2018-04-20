using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blueapp.Models;

namespace Blueapp.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            // Initialize list of Items
            List<ItemModel> items = new List<ItemModel>() { new ItemModel() { id = 1, name = "Item 1", reviewDate = DateTime.Now, reminder = false, completionStatus = false, completetionDate = DateTime.Now},
            new ItemModel() { id = 2, name = "Item 2", reviewDate = DateTime.Now, reminder = true, completionStatus = false, completetionDate = DateTime.Now},
            new ItemModel() { id = 3, name = "Item 3", reviewDate = DateTime.Now, reminder = false, completionStatus = false, completetionDate = DateTime.Now}};

            return View(items);
        }
    }
}