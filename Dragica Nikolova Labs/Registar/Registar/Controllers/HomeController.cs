using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
using Registar.Models;
using Registar.BL.Contracts.Contracts;
using System.Web.Script.Serialization;

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
            //return View();

        }

        public ActionResult Index2()
        {
            //BikeSearchCommand _command = new BikeSearchCommand();
            //BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            //

            //return View(_result.Result);
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Registar.DomainModel.Bike bike)
        {
            BikeCreateCommand _command = new BikeCreateCommand();
            _command.BikeOwnerId = bike.BikeOwnerId;
            _command.RegNumber = bike.RegNumber;
            _command.Colour = bike.Colour;
            _command.Producer = bike.Producer;
            _command.Model = bike.Model;
            BikeCreateResult _result = CommandInvoker.InvokeCommand<BikeCreateCommand, BikeCreateResult>(_command);
                
            return View();            
        }
        [ActionName("Index2"), HttpPost]
        public ActionResult GetSearchResult()
        {
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);

            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(_result.Result);

            return new JsonResult() { Data = serializedResult, JsonRequestBehavior = JsonRequestBehavior.AllowGet }; 
        }

    }
}
