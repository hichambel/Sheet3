using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BLL;
using ContactLab.Models;

namespace ContactLab.Controllers
{
  
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        // GET: Home
        public ActionResult Index()
        {
            var records = myModel.getList();
            return View(records);
        }

        public ActionResult Details(int id)
        {
            var records = myModel.getContactDetails(id);
            return View(records);
        }

        public ActionResult Delete(int id)
        {
            myModel.deleteRecord(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Contact contact)
        {
            myModel.addRecord(contact);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var currentRecord = myModel.getContactDetails(id);

            return View(currentRecord);
        }
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            myModel.updateRecords(contact);

            return RedirectToAction("Index");
        }
    }
}