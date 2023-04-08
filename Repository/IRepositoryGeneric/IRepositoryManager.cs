using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.IRepositoryGeneric
{
    public interface IRepositoryManager
    {
        // Para evitar estar creando clases y interfaces para cada tabla
        ICompanyRepository Company { get; } 
        IEmployeeRepository Employee { get; }

        void Save();
    }
}