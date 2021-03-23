using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_Offers_Website.Entities;
using Job_Offers_Website.Models;

namespace Job_Offers_Website.Controllers
{
    public class UsersController : Controller
    {
        private UsersModel usersModel = new UsersModel();

        // GET: Users
        public ActionResult Index()
        {
            ViewBag.users = usersModel.findAll();

            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View("Add" , new Users());
        }

        [HttpPost]
        public ActionResult Add(Users users)
        {

            usersModel.create(users);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            usersModel.delete(id);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(string id)
        {

            return View("Edit", usersModel.find(id) );
        }

        [HttpPost]
        public ActionResult Edit(Users users , FormCollection fc)
        {
            string id = fc["Id"];
            var user = usersModel.find(id);
            if(users.Password != null)
            {
                user.Password = user.Password;
            }
            user.Username = users.Username;
            user.Email = users.Email;
            user.Age = users.Age;
            usersModel.update(user);
            return RedirectToAction("Index");

           
        }
    }
}