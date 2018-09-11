using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Contractors.Models;

namespace Contractors
{
    public interface IContractorsRepository
    {
         List<Contractor> GetAll();
         Contractor Details(int id);
          Contractor Edit(Contractor contractor, int id);
          void  Delete(Contractor contractor, int id);
          void Create(Contractor contractor);
    }
}
