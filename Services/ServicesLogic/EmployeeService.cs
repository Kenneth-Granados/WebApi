using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.IServicesLogic;

namespace Services.ServicesLogic
{
    internal sealed class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _repository; 
        private readonly ILoggerManager _logger; 
        public EmployeeService(IRepositoryManager repository, ILoggerManager logger) { 
            _repository = repository; _logger = logger; } 
    }
}