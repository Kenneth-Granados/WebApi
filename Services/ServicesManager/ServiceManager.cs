using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.IServicesLogic;
using Services.ServicesLogic;

namespace Services.ServicesManager
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService; 
        private readonly Lazy<IEmployeeService> _employeeService; 
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger) { 
            _companyService = new Lazy<ICompanyService>(() => 
                new CompanyService(repositoryManager, logger)); 
            _employeeService = new Lazy<IEmployeeService>(() => 
                new EmployeeService(repositoryManager, logger)); } 
        public ICompanyService CompanyService => _companyService.Value; 
        public IEmployeeService EmployeeService => _employeeService.Value;
    }
}

// Aquí, como hicimos con la clase RepositoryManager, estamos utilizando el
// Lazy class para garantizar la inicialización diferida de nuestros servicios.
// Ahora, con todo esto en su lugar, tenemos que agregar la referencia de la
// Servicioproyecto dentro del proyecto principal.
