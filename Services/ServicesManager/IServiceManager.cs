using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.IServicesLogic;

namespace Services.ServicesManager
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; } 
        IEmployeeService EmployeeService { get; }
    }
}