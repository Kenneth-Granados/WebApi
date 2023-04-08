using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.RepositoryGeneric
{
    public class CompanyRepository : RepositoryGeneric<TblCompany>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<TblCompany> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges) 
            .OrderBy(c => c.Name) 
            .ToList();
    }
}