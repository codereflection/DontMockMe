﻿using System.Collections.Generic;
using System.Web.Mvc;
using DontMockMe.Core.Models;

namespace DontMockMe.Web.Controllers
{
    public class FuzzieBunniesController : Controller
    {
        //
        // GET: /FuzzieBunnies/

        public ActionResult Index()
        {
            return View(new List<FuzzieBunny>());
        }

        //
        // GET: /FuzzieBunnies/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /FuzzieBunnies/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /FuzzieBunnies/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /FuzzieBunnies/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FuzzieBunnies/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /FuzzieBunnies/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FuzzieBunnies/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
