using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.IServicesLogic
{
    public interface ICompanyService
    {
        IEnumerable<TblCompany> GetAllCompanies(bool trackChanges);
    }
}