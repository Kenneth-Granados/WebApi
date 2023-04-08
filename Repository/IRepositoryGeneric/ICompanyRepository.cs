using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.IRepositoryGeneric
{
    public interface ICompanyRepository
    {
        IEnumerable<TblCompany> GetAllCompanies(bool trackChanges);
    }
}