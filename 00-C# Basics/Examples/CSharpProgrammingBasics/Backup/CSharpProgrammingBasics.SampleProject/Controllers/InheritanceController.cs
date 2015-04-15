using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpProgrammingBasics.Library.Samples.Inheritance;

namespace CSharpProgrammingBasics.SampleProject.Controllers
{
    public class InheritanceController : Controller
    {
        //
        // GET: /Inheritance/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OverrideNewDifference()
        {
            return View();
        }

        public ActionResult OverriddenExample()
        {
            StartEngineOptions _startOptions = StartEngineOptions.TurnOffLightsBeforeStart;
            _startOptions |= StartEngineOptions.TurnOffRadioBeforeStart;
            _startOptions |= StartEngineOptions.TurnOnLightsAfterStart;
            //ok start the engines
            List<AbstractCar> _result = new List<AbstractCar>();
            AbstractCar _sampleClassInstance = new CombustionEngineCar();
            _sampleClassInstance.Colour = Colours.Blue;
            _sampleClassInstance.StartEngine(_startOptions);
            _result.Add(_sampleClassInstance);
            //
            _sampleClassInstance = new CombustionEngineCarEnglishVersion();
            _sampleClassInstance.Colour = Colours.Green;
            _sampleClassInstance.StartEngine(_startOptions);
            _result.Add(_sampleClassInstance);
            //
            _sampleClassInstance = new ElectricCar();
            _sampleClassInstance.Colour = Colours.Red;
            _sampleClassInstance.StartEngine(_startOptions);
            _result.Add(_sampleClassInstance);           
            return View("CarDetails",_result);
        }

        public ActionResult HiddenExample()
        {
            StartEngineOptions _startOptions = StartEngineOptions.TurnOffLightsBeforeStart;
            _startOptions |= StartEngineOptions.TurnOffRadioBeforeStart;
            _startOptions |= StartEngineOptions.TurnOnLightsAfterStart;
            //ok start the engines
            List<AbstractCar> _result = new List<AbstractCar>();
            CombustionEngineCar _comubustionEngineCar = new CombustionEngineCar();
            _comubustionEngineCar.Colour = Colours.Blue;
            _comubustionEngineCar.StartEngine(_startOptions);
            _result.Add(_comubustionEngineCar);
            //
            CombustionEngineCarEnglishVersion _combustionEngineEnglish = new CombustionEngineCarEnglishVersion();
            _combustionEngineEnglish.Colour = Colours.Green;
            _combustionEngineEnglish.StartEngine(_startOptions);
            _result.Add(_combustionEngineEnglish);
            //
            ElectricCar _electricCar = new ElectricCar();
            _electricCar.Colour = Colours.Red;
            _electricCar.StartEngine(_startOptions);
            _result.Add(_electricCar);
            return View("CarDetails", _result);
        }


    }
}
