using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contractors;
using Contractors.Controllers;
using Contractors.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace CUnitTests
{
    [TestClass]
    public class ContractorsControllerUnitTests
    {
        IContractorsRepository testContractorsRepository = new TestContractorsRepository();

        [TestMethod]
        public void TestGetAll()
        {
            var contractorController = new ContractorsController(testContractorsRepository);
            var result = contractorController.GetAll() as ViewResult;
            var contractors = (List<Contractor>)result.ViewData.Model;

            Assert.AreEqual(1, contractors[0].Id);
            Assert.AreEqual("Orlen", contractors[0].Name);
            Assert.AreEqual("Poland", contractors[0].Country);
            Assert.AreEqual("Płock", contractors[0].City);
            Assert.AreEqual("Naftowa", contractors[0].Street);
            Assert.AreEqual(10, contractors[0].HouseNumber);
            Assert.AreEqual(32510, contractors[0].PostalCode);
            Assert.AreEqual("orlen@orlen.pl", contractors[0].Email);
            Assert.AreEqual(123456789, contractors[0].PhoneNumber);
            Assert.AreEqual(500400300, contractors[0].NIP);
            Assert.AreEqual("00005000888", contractors[0].AccountNumber);
        }

        [TestMethod]
        public void TestDetails()
        {
            var contractorController = new ContractorsController(testContractorsRepository);
            var result = contractorController.Details(1) as ViewResult;
            var contractor = (Contractor)result.ViewData.Model;

            Assert.AreEqual(1, contractor.Id);
            Assert.AreEqual("Orlen", contractor.Name);
            Assert.AreEqual("Poland", contractor.Country);
            Assert.AreEqual("Płock", contractor.City);
            Assert.AreEqual("Naftowa", contractor.Street);
            Assert.AreEqual(10, contractor.HouseNumber);
            Assert.AreEqual(32510, contractor.PostalCode);
            Assert.AreEqual("orlen@orlen.pl", contractor.Email);
            Assert.AreEqual(123456789, contractor.PhoneNumber);
            Assert.AreEqual(500400300, contractor.NIP);
            Assert.AreEqual("00005000888", contractor.AccountNumber);
        }

        [TestMethod]
        public void TestEdit()
        {
            var contractorController = new ContractorsController(testContractorsRepository);
            var result = contractorController.Edit(1) as ViewResult;
            var contractor = (Contractor)result.ViewData.Model;

            Assert.AreEqual(1, contractor.Id);
            Assert.AreEqual("Orlen", contractor.Name);
            Assert.AreEqual("Poland", contractor.Country);
            Assert.AreEqual("Płock", contractor.City);
            Assert.AreEqual("Naftowa", contractor.Street);
            Assert.AreEqual(10, contractor.HouseNumber);
            Assert.AreEqual(32510, contractor.PostalCode);
            Assert.AreEqual("orlen@orlen.pl", contractor.Email);
            Assert.AreEqual(123456789, contractor.PhoneNumber);
            Assert.AreEqual(500400300, contractor.NIP);
            Assert.AreEqual("00005000888", contractor.AccountNumber);
        }

        [TestMethod]
        public void TestEditWith2Parameters()
        {
            var contractorController = new ContractorsController(testContractorsRepository);
            Contractor contractorToEdit = new Contractor();
            contractorToEdit.Id = 1;
            contractorToEdit.Name = "Orlen";
            contractorToEdit.Country = "Poland";
            contractorToEdit.City = "Płock";
            contractorToEdit.Street = "Naftowa";
            contractorToEdit.HouseNumber = 10;
            contractorToEdit.PostalCode = 32510;
            contractorToEdit.Email = "orlen@orlen.pl";
            contractorToEdit.PhoneNumber = 123456789;
            contractorToEdit.NIP = 500400300;
            contractorToEdit.AccountNumber = "00005000888";
            var result = contractorController.Edit(contractorToEdit, 1) as RedirectToRouteResult;
            Assert.AreEqual("GetAll", result.RouteValues["Action"]);
        }

        [TestMethod]
        public void TestCreate()
        {
            var contractorController = new ContractorsController(testContractorsRepository);
            Contractor newContractor = new Contractor();
            newContractor.Id = 1;
            newContractor.Name = "Orlen";
            newContractor.Country = "Poland";
            newContractor.City = "Płock";
            newContractor.Street = "Naftowa";
            newContractor.HouseNumber = 10;
            newContractor.PostalCode = 32510;
            newContractor.Email = "orlen@orlen.pl";
            newContractor.PhoneNumber = 123456789;
            newContractor.NIP = 500400300;
            newContractor.AccountNumber = "00005000888";
            var result = contractorController.Create(newContractor) as RedirectToRouteResult;
            Assert.AreEqual("GetAll", result.RouteValues["action"]);
        }
    } 
}
