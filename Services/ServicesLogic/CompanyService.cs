using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.IServicesLogic;


namespace Services.ServicesLogic
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repository; 
        private readonly ILoggerManager _logger; 
        public CompanyService(IRepositoryManager repository, ILoggerManager logger) { 
            _repository = repository; _logger = logger; }

        public IEnumerable<TblCompany> GetAllCompanies(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}

// Como puede ver, nuestra clase hereda de la ICompanyService,
// y estamos inyectando el IRepositoryManager y ILoggerManager
// interfaces vamos a usar IRepositoryManagerpara acceder a la
// métodos de repositorio de cada clase de repositorio de usuario (CompanyRepository
// o EmployeeRepository), y ILoggerManagerpara acceder al registro
// métodos que hemos creado