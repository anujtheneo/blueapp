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
        static List<UserModel> users = new List<UserModel>() { new UserModel() { id = "asharma", name = "Anuj Sharma", password = "Ransome", superuser = false},
        new UserModel() { id = "asharma1", name = "Sharma Ji", password = "ransome", superuser = true}};

        static List<string> distributionList = new List<string> { "anuj.shrma10@gmail.com", "anuj.sharma@scotiabank.com" };

        static List<ItemModel> items = new List<ItemModel>() { new ItemModel() { id = 1, name = "Item 1", reviewDate = DateTime.Now, reminder = false, completionStatus = false, completetionDate = DateTime.Now, itemType = "Annual Review", approvers = users , distributionList = distributionList },
        new ItemModel() { id = 2, name = "Item 2", reviewDate = DateTime.Now, reminder = true, completionStatus = false, completetionDate = DateTime.Now, itemType = "Master Config", approvers = users , distributionList = distributionList },
        new ItemModel() { id = 3, name = "Item 3", reviewDate = DateTime.Now, reminder = false, completionStatus = false, completetionDate = DateTime.Now, itemType = "Annual Review"}};
            

        // GET: Items
        public ActionResult Index()
        {
            // Initialize list of Items            
            return View(items);
        }

        public ViewResult Detail(int id)
        {
            return View(items[id - 1]);
        }

        public ViewResult Edit(int id)
        {
            return View(items[id - 1]);
        }

    }
}