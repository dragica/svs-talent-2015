using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using Registar.BL.Contracts.Contracts;

namespace Registar.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //call BL
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //
            return View(_result.Result);
        }

        public ActionResult Index2()
        {
            List<BikeModel> _result = new List<BikeModel>();
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            _result.Add(new BikeModel() { Colour = "red", Model = "R1", Producer = "Specialized", RegNumber = "007" });
            //
            this.ViewBag.SomeNewProperty = "theValue";
            this.ViewData["SomeNewProperty"] = "theValue";
            //
            return View("Index",_result);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckingAccount/Create
        [HttpPost]
        public ActionResult Create(Registar.DomainModel.Bike bike)
        {
            //try
            //{
                BikeCreateCommand _command = new BikeCreateCommand();
                _command.BikeOwnerId = bike.BikeOwnerId;
                _command.RegNumber = bike.RegNumber;
                _command.Colour = bike.Colour;
                _command.Producer = bike.Producer;
                _command.Model = bike.Model;
                BikeCreateResult _result = CommandInvoker.InvokeCommand<BikeCreateCommand, BikeCreateResult>(_command);
                //
                //return View(_result.Result);

                return RedirectToAction("Index", "Home");
            //}
            //catch
            //{
            //    return View();
            //}
        }

    }
}
