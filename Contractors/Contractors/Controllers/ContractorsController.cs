using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contractors.Models;
using Contractors.Repositories;


namespace Contractors.Controllers
{
    public class ContractorsController : Controller
    {

        private readonly IContractorsRepository _contractorsRepository;

        public ContractorsController(IContractorsRepository contractorsRepository)
        {
            _contractorsRepository = contractorsRepository;
        }
        public ContractorsController():this(new ContractorsRepository()) { }



        public ActionResult GetAll()
        {
            return View(_contractorsRepository.GetAll());
        }
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Details(int id)
        {
            return View(_contractorsRepository.Details(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contractor contractor)
        {
            if (ModelState.IsValid)
            {
                _contractorsRepository.Create(contractor);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(contractor);
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_contractorsRepository.Details(id));
        }
        [HttpPost]
        public ActionResult Edit(Contractor contractor, int id)
        {
            if (ModelState.IsValid)
            {
                _contractorsRepository.Edit(contractor, id);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(contractor);
            }

        }

        public ActionResult Delete(int id)
        {
            return View(_contractorsRepository.Details(id));
        }
        [HttpPost]
        public ActionResult Delete(Contractor contractor,int id)
        {
            if (ModelState.IsValid)
            {
                _contractorsRepository.Delete(contractor,id);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(contractor);
            }
        }
    }
}
