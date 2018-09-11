using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contractors;
using Contractors.Models;

namespace CUnitTests
{
    public class TestContractorsRepository: IContractorsRepository
    {
        public List<Contractor> GetAll()
        {
            List<Contractor> contractors = new List<Contractor>();
            Contractor testContractor = new Contractor();
            testContractor.Id = 1;
            testContractor.Name = "Orlen";
            testContractor.Country = "Poland";
            testContractor.City = "Płock";
            testContractor.Street = "Naftowa";
            testContractor.HouseNumber = 10;
            testContractor.PostalCode = 32510;
            testContractor.Email = "orlen@orlen.pl";
            testContractor.PhoneNumber = 123456789;
            testContractor.NIP = 500400300;
            testContractor.AccountNumber = "00005000888";

            contractors.Add(testContractor);
            return contractors;
        }
        public Contractor Details(int id)
        {
            Contractor testContractor = new Contractor();
            testContractor.Id = 1;
            testContractor.Name = "Orlen";
            testContractor.Country = "Poland";
            testContractor.City = "Płock";
            testContractor.Street = "Naftowa";
            testContractor.HouseNumber = 10;
            testContractor.PostalCode = 32510;
            testContractor.Email = "orlen@orlen.pl";
            testContractor.PhoneNumber = 123456789;
            testContractor.NIP = 500400300;
            testContractor.AccountNumber = "00005000888";

            return testContractor;
        }
        public Contractor Edit(Contractor contractor, int id)
        {
            Contractor testContractor = new Contractor();
            testContractor.Id = 1;
            testContractor.Name = "Orlen";
            testContractor.Country = "Poland";
            testContractor.City = "Płock";
            testContractor.Street = "Naftowa";
            testContractor.HouseNumber = 10;
            testContractor.PostalCode = 32510;
            testContractor.Email = "orlen@orlen.pl";
            testContractor.PhoneNumber = 123456789;
            testContractor.NIP = 500400300;
            testContractor.AccountNumber = "00005000888";

            return testContractor;
        }
        public void Delete(Contractor contractor, int id)
        {
            
        }
        public void Create(Contractor contractor)
        {
            
        }






    }
}
